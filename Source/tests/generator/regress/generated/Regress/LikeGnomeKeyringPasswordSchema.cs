// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct LikeGnomeKeyringPasswordSchema : IEquatable<LikeGnomeKeyringPasswordSchema> {

		public int Dummy;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=32)]
		public IntPtr[] Attributes;
		public double Dummy2;

		public static Regress.LikeGnomeKeyringPasswordSchema Zero = new Regress.LikeGnomeKeyringPasswordSchema ();

		public static Regress.LikeGnomeKeyringPasswordSchema New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.LikeGnomeKeyringPasswordSchema.Zero;
			return (Regress.LikeGnomeKeyringPasswordSchema) Marshal.PtrToStructure (raw, typeof (Regress.LikeGnomeKeyringPasswordSchema));
		}

		public bool Equals (LikeGnomeKeyringPasswordSchema other)
		{
			return true && Dummy.Equals (other.Dummy) && Attributes.Equals (other.Attributes) && Dummy2.Equals (other.Dummy2);
		}

		public override bool Equals (object other)
		{
			return other is LikeGnomeKeyringPasswordSchema && Equals ((LikeGnomeKeyringPasswordSchema) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Dummy.GetHashCode () ^ Attributes.GetHashCode () ^ Dummy2.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
