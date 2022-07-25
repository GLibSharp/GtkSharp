using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Generator.Tests {
	public static class NativeLibraryResolver {
		static readonly Dictionary<string, Dictionary<OSPlatform, string>> LIBS_MAPPING = new()
		{

			{
				"regress-1.0",
				new Dictionary<OSPlatform, string> {
					{OSPlatform.Linux, "libregress-1.0.so" },
					{OSPlatform.Windows, "libregress-1.0.dll" },
					{OSPlatform.OSX, "libregress-1.0.dylib" },
				}
			},
			{
				"glib-2.0-0.dll",
				new Dictionary<OSPlatform, string> {
					{OSPlatform.Linux, "libglib-2.0.so.0" },
					{OSPlatform.Windows, "glib-2.0-0.dll" },
					{OSPlatform.OSX, "libglib-2.0.0.dylib" },
				}
			},
			{
				"gobject-2.0-0.dll",
				new Dictionary<OSPlatform, string> {
					{OSPlatform.Linux, "libgobject-2.0.so.0" },
					{OSPlatform.Windows, "gobject-2.0-0.dll" },
					{OSPlatform.OSX, "libgobject-2.0.0.dylib" },
				}
			},
			{
				"gio-2.0-0.dll",
				new Dictionary<OSPlatform, string> {
					{OSPlatform.Linux, "libgio-2.0.so.0" },
					{OSPlatform.Windows, "gio-2.0-0.dll" },
					{OSPlatform.OSX, "libgio-2.0.0.dylib" },
				}
			},

		};

		static List<string> searchDirs = new List<string>();

		public static void Init(List<string> searchDirs) {
			NativeLibraryResolver.searchDirs = searchDirs;
			// glib-sharp
			NativeLibrary.SetDllImportResolver(typeof(GLib.AbiField).Assembly, ImportResolver);
			// gio-sharp
			NativeLibrary.SetDllImportResolver(typeof(GLib.Application).Assembly, ImportResolver);
			// regress
			NativeLibrary.SetDllImportResolver(typeof(Regress.AnAnonymousUnion).Assembly, ImportResolver);
		}

		static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath) {
			IntPtr libPtr = IntPtr.Zero;
			foreach (var dir in searchDirs) {
				libPtr = TryLoad(libraryName, assembly, searchPath, dir);
				if (libPtr != IntPtr.Zero) {
					break;
				}
			}
			return libPtr;
		}

		private static IntPtr TryLoad(string libName, Assembly assembly, DllImportSearchPath? searchPath, string searchDir) {
			IntPtr libHandle;
			string libraryName = libName;

			if (LIBS_MAPPING.TryGetValue(libName, out var osToNameDict)) {
				if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
					libraryName = osToNameDict[OSPlatform.OSX];
				} else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
					libraryName = osToNameDict[OSPlatform.Windows];
				} else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
					libraryName = osToNameDict[OSPlatform.Linux];
				} else {
					throw new NotSupportedException("Operating system not supported");
				}
				libraryName = Path.Join(searchDir, libraryName);
			}

			if (searchPath != null) {
				NativeLibrary.TryLoad(libraryName, assembly, searchPath, out libHandle);
			} else {
				NativeLibrary.TryLoad(libraryName, assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
			}

			return libHandle;
		}
	}
}