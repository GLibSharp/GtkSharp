// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void SigWithInt64PropHandler(object o, SigWithInt64PropArgs args);

	public class SigWithInt64PropArgs : GLib.SignalArgs {
		public long I{
			get {
				return (long) Args [0];
			}
		}

	}
}
