// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void ToEmbedderHandler(object o, ToEmbedderArgs args);

	public class ToEmbedderArgs : GLib.SignalArgs {
		public double OffscreenX{
			get {
				return (double) Args [0];
			}
		}

		public double OffscreenY{
			get {
				return (double) Args [1];
			}
		}

		public double EmbedderX{
			set {
				Args[2] = (double)value;
			}
		}

		public double EmbedderY{
			set {
				Args[3] = (double)value;
			}
		}

	}
}
