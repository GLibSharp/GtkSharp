// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.SelectionModeGType))]
	public enum SelectionMode {

		None,
		Single,
		Browse,
		Multiple,
	}

	internal class SelectionModeGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_selection_mode_get_type ());
			}
		}
	}
#endregion
}
