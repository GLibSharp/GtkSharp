// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Gradient : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_get_type();

		[Obsolete]
		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gradient_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_to_string(IntPtr raw);

		[Obsolete]
		public override string ToString() {
			IntPtr raw_ret = gtk_gradient_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		public Gradient(IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_new_linear(double x0, double y0, double x1, double y1);

		public Gradient (double x0, double y0, double x1, double y1) 
		{
			Raw = gtk_gradient_new_linear(x0, y0, x1, y1);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);

		public Gradient (double x0, double y0, double radius0, double x1, double y1, double radius1) 
		{
			Raw = gtk_gradient_new_radial(x0, y0, radius0, x1, y1, radius1);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_gradient_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Gtk.Gradient is now refcounted automatically")]
		public Gradient Ref () { return this; }

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gradient_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_gradient_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Gtk.Gradient is now refcounted automatically")]
		public void Unref () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_gradient_unref (handle);
				return false;
			}
		}

		~Gradient ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
