//
//  RadioButton.cs
//
//	Author:  John Luke  <jluke@cfl.rr.com>
//
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

	public partial class RadioButton {

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_radio_button_new_with_mnemonic(IntPtr group, IntPtr label);

		// creates a new group for this RadioButton
		public RadioButton(string label) {
			IntPtr native = GLib.Marshaller.StringToPtrGStrdup(label);
			Raw = gtk_radio_button_new_with_mnemonic(IntPtr.Zero, native);
			GLib.Marshaller.Free(native);
		}

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_radio_button_get_group(IntPtr raw);

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_radio_button_set_group(IntPtr raw, IntPtr list);

		[GLib.Property("group")]
		public RadioButton[] Group {
			get {
				IntPtr raw_ret = gtk_radio_button_get_group(Handle);
				RadioButton[] ret = (RadioButton[])GLib.Marshaller.ListPtrToArray(raw_ret, typeof(GLib.SList), false, false, typeof(RadioButton));
				return ret;
			}
			set {
				IntPtr native_group = IntPtr.Zero;
				if (value != null) {
					GLib.List list = new GLib.List(IntPtr.Zero);
					foreach (RadioButton item in value) {
						list.Append(item.Handle);
					}
					native_group = list.Handle;
				}
				gtk_radio_button_set_group(Handle, native_group);
			}
		}
	}
}