// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.ByteOrderGType))]
	public enum ByteOrder {

		LsbFirst,
		MsbFirst,
	}

	internal class ByteOrderGType {
		[DllImport ("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_byte_order_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_byte_order_get_type ());
			}
		}
	}
#endregion
}