// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Atk.LayerGType))]
	public enum Layer {

		Invalid,
		Background,
		Canvas,
		Widget,
		Mdi,
		Popup,
		Overlay,
		Window,
	}

	internal class LayerGType {
		[DllImport ("atk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_layer_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (atk_layer_get_type ());
			}
		}
	}
#endregion
}