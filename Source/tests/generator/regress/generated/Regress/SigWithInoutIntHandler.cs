// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void SigWithInoutIntHandler(object o, SigWithInoutIntArgs args);

	public class SigWithInoutIntArgs : GLib.SignalArgs {
		public int Position {
			get {
				return (int)Args[0];
			}
			set {
				Args[0] = (int)value;
			}
		}

	}
}