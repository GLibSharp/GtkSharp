// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Regress.TestOtherErrorGType))]
	public enum TestOtherError {

		Code1 = 1,
		Code2 = 2,
		Code3 = 3,
	}

	internal class TestOtherErrorGType {
		[DllImport ("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_unconventional_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (regress_test_unconventional_error_get_type ());
			}
		}
	}
#endregion
}
