// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextLayout : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_text_layout_draw(IntPtr raw, IntPtr widget, IntPtr cr, IntPtr widgets);

		public void Draw(Gtk.Widget widget, Cairo.Context cr, GLib.List widgets) {
			gtk_text_layout_draw(Handle, widget == null ? IntPtr.Zero : widget.Handle, cr == null ? IntPtr.Zero : cr.Handle, widgets == null ? IntPtr.Zero : widgets.Handle);
		}

		public TextLayout(IntPtr raw) : base(raw) {}

		protected TextLayout() : base() {}


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
