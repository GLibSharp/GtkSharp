// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.TextDirectionGType))]
	public enum TextDirection {

		None,
		Ltr,
		Rtl,
	}

	internal class TextDirectionGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_direction_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_text_direction_get_type ());
			}
		}
	}
#endregion
}
