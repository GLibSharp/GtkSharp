// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RcProperty : IEquatable<RcProperty> {

		public int TypeName;
		public int PropertyName;
		public string Origin;
		public GLib.Value Value;

		public static Gtk.RcProperty Zero = new Gtk.RcProperty ();

		public static Gtk.RcProperty New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.RcProperty.Zero;
			return (Gtk.RcProperty) Marshal.PtrToStructure (raw, typeof (Gtk.RcProperty));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_property_parse_border(IntPtr pspec, IntPtr gstring, IntPtr property_value);

		public static bool ParseBorder(IntPtr pspec, string gstring, GLib.Value property_value) {
			IntPtr native_property_value = GLib.Marshaller.StructureToPtrAlloc (property_value);
			bool raw_ret = gtk_rc_property_parse_border(pspec, new GLib.GString (gstring).Handle, native_property_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_property_value);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_property_parse_color(IntPtr pspec, IntPtr gstring, IntPtr property_value);

		public static bool ParseColor(IntPtr pspec, string gstring, GLib.Value property_value) {
			IntPtr native_property_value = GLib.Marshaller.StructureToPtrAlloc (property_value);
			bool raw_ret = gtk_rc_property_parse_color(pspec, new GLib.GString (gstring).Handle, native_property_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_property_value);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_property_parse_enum(IntPtr pspec, IntPtr gstring, IntPtr property_value);

		public static bool ParseEnum(IntPtr pspec, string gstring, GLib.Value property_value) {
			IntPtr native_property_value = GLib.Marshaller.StructureToPtrAlloc (property_value);
			bool raw_ret = gtk_rc_property_parse_enum(pspec, new GLib.GString (gstring).Handle, native_property_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_property_value);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_property_parse_flags(IntPtr pspec, IntPtr gstring, IntPtr property_value);

		public static bool ParseFlags(IntPtr pspec, string gstring, GLib.Value property_value) {
			IntPtr native_property_value = GLib.Marshaller.StructureToPtrAlloc (property_value);
			bool raw_ret = gtk_rc_property_parse_flags(pspec, new GLib.GString (gstring).Handle, native_property_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_property_value);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_property_parse_requisition(IntPtr pspec, IntPtr gstring, IntPtr property_value);

		public static bool ParseRequisition(IntPtr pspec, string gstring, GLib.Value property_value) {
			IntPtr native_property_value = GLib.Marshaller.StructureToPtrAlloc (property_value);
			bool raw_ret = gtk_rc_property_parse_requisition(pspec, new GLib.GString (gstring).Handle, native_property_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_property_value);
			return ret;
		}

		public bool Equals (RcProperty other)
		{
			return true && TypeName.Equals (other.TypeName) && PropertyName.Equals (other.PropertyName) && Origin.Equals (other.Origin) && Value.Equals (other.Value);
		}

		public override bool Equals (object other)
		{
			return other is RcProperty && Equals ((RcProperty) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ TypeName.GetHashCode () ^ PropertyName.GetHashCode () ^ Origin.GetHashCode () ^ Value.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
