// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gdk.WindowHintsGType))]
	public enum WindowHints : uint {

		Pos = 1 << 0,
		MinSize = 1 << 1,
		MaxSize = 1 << 2,
		BaseSize = 1 << 3,
		Aspect = 1 << 4,
		ResizeInc = 1 << 5,
		WinGravity = 1 << 6,
		UserPos = 1 << 7,
		UserSize = 1 << 8,
	}

	internal class WindowHintsGType {
		[DllImport ("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_window_hints_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_window_hints_get_type ());
			}
		}
	}
#endregion
}
