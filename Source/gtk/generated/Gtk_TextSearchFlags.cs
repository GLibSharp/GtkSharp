// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.TextSearchFlagsGType))]
	public enum TextSearchFlags : uint {

		VisibleOnly = 1 << 0,
		TextOnly = 1 << 1,
		CaseInsensitive = 1 << 2,
	}

	internal class TextSearchFlagsGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_search_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_text_search_flags_get_type ());
			}
		}
	}
#endregion
}
