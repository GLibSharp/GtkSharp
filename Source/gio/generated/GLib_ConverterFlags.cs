// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.ConverterFlagsGType))]
	public enum ConverterFlags : uint {

		NoFlags,
		InputAtEnd = 1 << 0,
		Flush = 1 << 1,
	}

	internal class ConverterFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_converter_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_converter_flags_get_type ());
			}
		}
	}
#endregion
}
