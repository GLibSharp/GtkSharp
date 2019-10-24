// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RGBA : IEquatable<RGBA> {

		public double Red;
		public double Green;
		public double Blue;
		public double Alpha;

		public static Gdk.RGBA Zero = new Gdk.RGBA ();

		public static Gdk.RGBA New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.RGBA.Zero;
			return (Gdk.RGBA) Marshal.PtrToStructure (raw, typeof (Gdk.RGBA));
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_rgba_copy(IntPtr raw);

		public Gdk.RGBA Copy() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gdk_rgba_copy(this_as_native);
			Gdk.RGBA ret = Gdk.RGBA.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_rgba_equal(IntPtr p1, IntPtr p2);

		public static bool Equal(IntPtr p1, IntPtr p2) {
			bool raw_ret = gdk_rgba_equal(p1, p2);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_rgba_free(IntPtr raw);

		public void Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gdk_rgba_free(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_rgba_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_rgba_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gdk_rgba_hash(IntPtr p);

		public static uint Hash(IntPtr p) {
			uint raw_ret = gdk_rgba_hash(p);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_rgba_parse(IntPtr raw, IntPtr spec);

		public bool Parse(string spec) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_spec = GLib.Marshaller.StringToPtrGStrdup (spec);
			bool raw_ret = gdk_rgba_parse(this_as_native, native_spec);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_spec);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_rgba_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gdk_rgba_to_string(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gdk.RGBA target)
		{
			target = New (native);
		}

		public bool Equals (RGBA other)
		{
			return true && Red.Equals (other.Red) && Green.Equals (other.Green) && Blue.Equals (other.Blue) && Alpha.Equals (other.Alpha);
		}

		public override bool Equals (object other)
		{
			return other is RGBA && Equals ((RGBA) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Red.GetHashCode () ^ Green.GetHashCode () ^ Blue.GetHashCode () ^ Alpha.GetHashCode ();
		}

#endregion
	}
}
