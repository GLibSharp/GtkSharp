// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gdk.WindowStateGType))]
	public enum WindowState : uint {

		Withdrawn = 1 << 0,
		Iconified = 1 << 1,
		Maximized = 1 << 2,
		Sticky = 1 << 3,
		Fullscreen = 1 << 4,
		Above = 1 << 5,
		Below = 1 << 6,
		Focused = 1 << 7,
		Tiled = 1 << 8,
	}

	internal class WindowStateGType {
		[DllImport ("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_window_state_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_window_state_get_type ());
			}
		}
	}
#endregion
}
