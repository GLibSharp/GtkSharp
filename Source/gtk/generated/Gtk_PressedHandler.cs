// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void PressedHandler(object o, PressedArgs args);

	public class PressedArgs : GLib.SignalArgs {
		public int NPress{
			get {
				return (int) Args [0];
			}
		}

		public double X{
			get {
				return (double) Args [1];
			}
		}

		public double Y{
			get {
				return (double) Args [2];
			}
		}

	}
}