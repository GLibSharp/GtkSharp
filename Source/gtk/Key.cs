// Key.cs - Key class implementation
//
// Author: Mike Kestner <mkestner@novell.com>
//
// Copyright (c) 2008 Novell, Inc.
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
	using System.Collections;
	using System.Runtime.InteropServices;

	public class Key {

		static Hashtable wrappers = new Hashtable();

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_key_snooper_install(GtkSharp.KeySnoopFuncNative snooper, IntPtr func_data);

		public static uint SnooperInstall(Gtk.KeySnoopFunc snooper) {
			GtkSharp.KeySnoopFuncWrapper snooper_wrapper = new GtkSharp.KeySnoopFuncWrapper(snooper);
			uint ret = gtk_key_snooper_install(snooper_wrapper.NativeDelegate, IntPtr.Zero);
			wrappers[ret] = snooper_wrapper;
			return ret;
		}

		[DllImport(Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_key_snooper_remove(uint snooper_handler_id);

		public static void SnooperRemove(uint snooper_handler_id) {
			gtk_key_snooper_remove(snooper_handler_id);
			wrappers.Remove(snooper_handler_id);
		}
	}
}