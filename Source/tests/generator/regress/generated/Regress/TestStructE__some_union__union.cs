// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Explicit)]
	public partial struct TestStructE__some_union__union : IEquatable<TestStructE__some_union__union> {

		[FieldOffset(0)]
		public int VInt;
		[FieldOffset(0)]
		public uint VUint;
		[FieldOffset(0)]
		private IntPtr v_long;
		public long VLong {
			get {
				return (long) v_long;
			}
			set {
				v_long = new IntPtr (value);
			}
		}
		[FieldOffset(0)]
		private UIntPtr v_ulong;
		public ulong VUlong {
			get {
				return (ulong) v_ulong;
			}
			set {
				v_ulong = new UIntPtr (value);
			}
		}
		[FieldOffset(0)]
		public long VInt64;
		[FieldOffset(0)]
		public ulong VUint64;
		[FieldOffset(0)]
		public float VFloat;
		[FieldOffset(0)]
		public double VDouble;
		[FieldOffset(0)]
		private IntPtr _v_pointer;

		public static Regress.TestStructE__some_union__union Zero = new Regress.TestStructE__some_union__union ();

		public static Regress.TestStructE__some_union__union New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.TestStructE__some_union__union.Zero;
			return (Regress.TestStructE__some_union__union) Marshal.PtrToStructure (raw, typeof (Regress.TestStructE__some_union__union));
		}

		public bool Equals (TestStructE__some_union__union other)
		{
			return true && VInt.Equals (other.VInt) && VUint.Equals (other.VUint) && VLong.Equals (other.VLong) && VUlong.Equals (other.VUlong) && VInt64.Equals (other.VInt64) && VUint64.Equals (other.VUint64) && VFloat.Equals (other.VFloat) && VDouble.Equals (other.VDouble) && _v_pointer.Equals (other._v_pointer);
		}

		public override bool Equals (object other)
		{
			return other is TestStructE__some_union__union && Equals ((TestStructE__some_union__union) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ VInt.GetHashCode () ^ VUint.GetHashCode () ^ VLong.GetHashCode () ^ VUlong.GetHashCode () ^ VInt64.GetHashCode () ^ VUint64.GetHashCode () ^ VFloat.GetHashCode () ^ VDouble.GetHashCode () ^ _v_pointer.GetHashCode ();
		}

#endregion
	}
}
