// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooEventAny : IEquatable<FooEventAny> {

		public sbyte SendEvent;

		public static Regress.FooEventAny Zero = new Regress.FooEventAny ();

		public static Regress.FooEventAny New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooEventAny.Zero;
			return (Regress.FooEventAny) Marshal.PtrToStructure (raw, typeof (Regress.FooEventAny));
		}

		public bool Equals (FooEventAny other)
		{
			return true && SendEvent.Equals (other.SendEvent);
		}

		public override bool Equals (object other)
		{
			return other is FooEventAny && Equals ((FooEventAny) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ SendEvent.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}