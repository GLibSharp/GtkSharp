// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufFormat : GLib.Opaque {

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_copy(IntPtr raw);

		public Gdk.PixbufFormat Copy() {
			IntPtr raw_ret = gdk_pixbuf_format_copy(Handle);
			Gdk.PixbufFormat ret = raw_ret == IntPtr.Zero ? null : (Gdk.PixbufFormat) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.PixbufFormat), true);
			return ret;
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_description(IntPtr raw);

		public string Description { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_description(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_extensions(IntPtr raw);

		public string[] Extensions { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_extensions(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_license(IntPtr raw);

		public string License { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_license(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_mime_types(IntPtr raw);

		public string[] MimeTypes { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_mime_types(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_format_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_format_is_disabled(IntPtr raw);

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_format_set_disabled(IntPtr raw, bool disabled);

		public bool Disabled { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_disabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gdk_pixbuf_format_set_disabled(Handle, value);
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_format_is_save_option_supported(IntPtr raw, IntPtr option_key);

		public bool IsSaveOptionSupported(string option_key) {
			IntPtr native_option_key = GLib.Marshaller.StringToPtrGStrdup (option_key);
			bool raw_ret = gdk_pixbuf_format_is_save_option_supported(Handle, native_option_key);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_option_key);
			return ret;
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_format_is_scalable(IntPtr raw);

		public bool IsScalable { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_scalable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_format_is_writable(IntPtr raw);

		public bool IsWritable { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_writable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		public PixbufFormat(IntPtr raw) : base(raw) {}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_format_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gdk_pixbuf_format_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gdk_pixbuf_format_free;
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
