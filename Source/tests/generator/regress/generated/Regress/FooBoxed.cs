// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooBoxed : IEquatable<FooBoxed> {


		public static Regress.FooBoxed Zero = new Regress.FooBoxed ();

		public static Regress.FooBoxed New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooBoxed.Zero;
			return (Regress.FooBoxed) Marshal.PtrToStructure (raw, typeof (Regress.FooBoxed));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_boxed_new();

		public static FooBoxed New()
		{
			FooBoxed result = FooBoxed.New (regress_foo_boxed_new());
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_boxed_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_foo_boxed_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_boxed_method(IntPtr raw);

		public void Method() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			regress_foo_boxed_method(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Regress.FooBoxed target)
		{
			target = New (native);
		}

		public bool Equals (FooBoxed other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is FooBoxed && Equals ((FooBoxed) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Regress.FooBoxed boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Regress.FooBoxed.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Regress.FooBoxed (GLib.Value val)
		{
			return (Regress.FooBoxed) val.Val;
		}
#endregion
	}
}
