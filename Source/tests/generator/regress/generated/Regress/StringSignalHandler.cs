// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void StringSignalHandler(object o, StringSignalArgs args);

	public class StringSignalArgs : GLib.SignalArgs {
		public string String{
			get {
				return (string) Args [0];
			}
		}

	}
}
