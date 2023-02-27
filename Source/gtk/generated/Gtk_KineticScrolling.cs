// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class KineticScrolling : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_kinetic_scrolling_tick(IntPtr raw, double time_delta, out double position);

		public bool Tick(double time_delta, out double position) {
			bool raw_ret = gtk_kinetic_scrolling_tick(Handle, time_delta, out position);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_kinetic_scrolling_new(double lower, double upper, double overshoot_width, double decel_friction, double overshoot_friction, double initial_position, double initial_velocity);

		public KineticScrolling (double lower, double upper, double overshoot_width, double decel_friction, double overshoot_friction, double initial_position, double initial_velocity) 
		{
			Raw = gtk_kinetic_scrolling_new(lower, upper, overshoot_width, decel_friction, overshoot_friction, initial_position, initial_velocity);
		}

		public KineticScrolling(IntPtr raw) : base(raw) {}

		protected KineticScrolling() : base() {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_kinetic_scrolling_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gtk_kinetic_scrolling_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gtk_kinetic_scrolling_free;
			}
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
