// SelectionData.cs - customizations for Gtk.SelectionData
//
// Authors:  Mike Kestner  <mkestner@ximian.com>
//
// Copyright (c) 2004  Novell, Inc.
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

	public partial class SelectionData {

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_selection_data_get_text(IntPtr selection_data);

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_selection_data_set_text(IntPtr selection_data, IntPtr str, int len);

		public string Text {
			get {
				IntPtr text = gtk_selection_data_get_text(Handle);
				if (text == IntPtr.Zero)
					return null;
				return GLib.Marshaller.PtrToStringGFree(text);
			}
			set {
				IntPtr native = GLib.Marshaller.StringToPtrGStrdup(value);
				gtk_selection_data_set_text(Handle, native, -1);
				GLib.Marshaller.Free(native);
			}
		}

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_selection_data_get_data(IntPtr selection_data);

		public byte[] Data {
			get {
				IntPtr data_ptr = gtk_selection_data_get_data(Handle);
				byte[] result = new byte[Length];
				Marshal.Copy(data_ptr, result, 0, Length);
				return result;
			}
		}

		public void Set(Gdk.Atom type, int format, byte[] data) {
			Set(type, format, data, data.Length);
		}

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_get_targets(IntPtr raw, out IntPtr targets, out int n_atoms);

		public Gdk.Atom[] Targets {
			get {
				IntPtr target_ptr;
				int count;
				if (gtk_selection_data_get_targets(Handle, out target_ptr, out count)) {
					Gdk.Atom[] result = new Gdk.Atom[count];
					for (int i = 0; i < count; i++) {
						IntPtr atom = Marshal.ReadIntPtr(target_ptr, count * IntPtr.Size);
						result[i] = new Gdk.Atom(atom);
					}
					GLib.Marshaller.Free(target_ptr);
					return result;
				} else
					return new Gdk.Atom[0];
			}
		}
	}
}