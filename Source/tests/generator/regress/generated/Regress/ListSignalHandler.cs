// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void ListSignalHandler(object o, ListSignalArgs args);

	public class ListSignalArgs : GLib.SignalArgs {
		public IntPtr List{
			get {
				return (IntPtr) Args [0];
			}
		}

	}
}