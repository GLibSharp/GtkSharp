// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.PasswordSaveGType))]
	public enum PasswordSave {

		Never,
		ForSession,
		Permanently,
	}

	internal class PasswordSaveGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_password_save_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_password_save_get_type ());
			}
		}
	}
#endregion
}