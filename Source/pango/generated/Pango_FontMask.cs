// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Pango.FontMaskGType))]
	public enum FontMask {

		Family = 1 << 0,
		Style = 1 << 1,
		Variant = 1 << 2,
		Weight = 1 << 3,
		Stretch = 1 << 4,
		Size = 1 << 5,
		Gravity = 1 << 6,
	}

	internal class FontMaskGType {
		[DllImport ("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_mask_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_font_mask_get_type ());
			}
		}
	}
#endregion
}
