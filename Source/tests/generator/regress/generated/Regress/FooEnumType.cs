// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Regress.FooEnumTypeGType))]
	public enum FooEnumType {

		Alpha = 0,
		Beta = 1,
		Delta = 2,
	}

	internal class FooEnumTypeGType {
		[DllImport ("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_enum_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (regress_foo_enum_type_get_type ());
			}
		}
	}
#endregion
}
