// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufAniAnim : Gdk.PixbufAnimation {

		public PixbufAniAnim (IntPtr raw) : base(raw) {}

		protected PixbufAniAnim() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_ani_anim_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_ani_anim_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
