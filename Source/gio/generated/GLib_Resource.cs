// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Resource : GLib.Opaque {

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resource_enumerate_children(IntPtr raw, IntPtr path, int lookup_flags, out IntPtr error);

		public unsafe string EnumerateChildren(string path, GLib.ResourceLookupFlags lookup_flags) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resource_enumerate_children(Handle, native_path, (int) lookup_flags, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_resource_error_quark();

		public static int ErrorQuark() {
			int raw_ret = g_resource_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_resource_get_info(IntPtr raw, IntPtr path, int lookup_flags, out UIntPtr size, out uint flags, out IntPtr error);

		public unsafe bool GetInfo(string path, GLib.ResourceLookupFlags lookup_flags, out ulong size, out uint flags) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			UIntPtr native_size;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_resource_get_info(Handle, native_path, (int) lookup_flags, out native_size, out flags, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			size = (ulong) native_size;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_resource_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_resource_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resource_load(IntPtr filename, out IntPtr error);

		public static unsafe GLib.Resource Load(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resource_load(native_filename, out error);
			GLib.Resource ret = raw_ret == IntPtr.Zero ? null : (GLib.Resource) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.Resource), false);
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resource_lookup_data(IntPtr raw, IntPtr path, int lookup_flags, out IntPtr error);

		public unsafe GLib.Bytes LookupData(string path, GLib.ResourceLookupFlags lookup_flags) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resource_lookup_data(Handle, native_path, (int) lookup_flags, out error);
			GLib.Bytes ret = new GLib.Bytes(raw_ret);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resource_open_stream(IntPtr raw, IntPtr path, int lookup_flags, out IntPtr error);

		public unsafe GLib.InputStream OpenStream(string path, GLib.ResourceLookupFlags lookup_flags) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resource_open_stream(Handle, native_path, (int) lookup_flags, out error);
			GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public Resource(IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resource_new_from_data(IntPtr data, out IntPtr error);

		public unsafe Resource (GLib.Bytes data) 
		{
			IntPtr error = IntPtr.Zero;
			Raw = g_resource_new_from_data(data == null ? IntPtr.Zero : data.Handle, out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_resource_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				g_resource_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resource_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				g_resource_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_resource_unref (handle);
				return false;
			}
		}

		~Resource ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			if (ForceFinalizeInMainThread) {
				GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
			} else {
				info.Handler();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
