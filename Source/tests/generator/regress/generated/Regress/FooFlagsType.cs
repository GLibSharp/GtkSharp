// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	[Flags]
	[GLib.GType(typeof(Regress.FooFlagsTypeGType))]
	public enum FooFlagsType : uint {

		First = 1,
		Second = 2,
		Third = 4,
	}

	internal class FooFlagsTypeGType {
		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_flags_type_get_type();

		public static GLib.GType GType {
			get {
				return new GLib.GType(regress_foo_flags_type_get_type());
			}
		}
	}
	#endregion
}