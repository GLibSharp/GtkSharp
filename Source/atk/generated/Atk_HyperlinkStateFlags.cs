// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Atk.HyperlinkStateFlagsGType))]
	public enum HyperlinkStateFlags : uint {

		Inline = 1 << 0,
	}

	internal class HyperlinkStateFlagsGType {
		[DllImport ("atk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_state_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (atk_hyperlink_state_flags_get_type ());
			}
		}
	}
#endregion
}
