// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.JunctionSidesGType))]
	public enum JunctionSides : uint {

		None,
		CornerTopLeft = 1 << 0,
		CornerTopRight = 1 << 1,
		CornerBottomLeft = 1 << 2,
		CornerBottomRight = 1 << 3,
		Top = CornerTopLeft | CornerTopRight,
		Bottom = CornerBottomLeft | CornerBottomRight,
		Left = CornerTopLeft | CornerBottomLeft,
		Right = CornerTopRight | CornerBottomRight,
	}

	internal class JunctionSidesGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_junction_sides_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_junction_sides_get_type ());
			}
		}
	}
#endregion
}
