// Util.cs - Atk Util class customizations
//
// Author: Mike Kestner <mkestner@novell.com>
//
// Copyright (c) 2008 Novell, Inc.
//
// This code is inserted after the automatically generated code.
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

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

	public partial class Util {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint AddGlobalEventListenerNativeDelegate (GLib.Signal.EmissionHookNative hook, IntPtr event_type);
                
		static AddGlobalEventListenerDelegate add_global_event_listener_handler;
		static AddGlobalEventListenerNativeDelegate add_global_event_listener_callback;

		static uint AddGlobalEventListenerCallback (GLib.Signal.EmissionHookNative hook, IntPtr event_type)
		{
			try {
				return add_global_event_listener_handler (new GLib.Signal.EmissionHookMarshaler (hook, IntPtr.Zero).Invoker, GLib.Marshaller.Utf8PtrToString (event_type));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
			return 0;
		}

		public delegate uint AddGlobalEventListenerDelegate (GLib.Signal.EmissionHook hook, string event_type);

		[DllImport("atksharpglue-3")]
		static extern void atksharp_util_override_add_global_event_listener (AddGlobalEventListenerNativeDelegate cb);
		public static AddGlobalEventListenerDelegate AddGlobalEventListenerHandler {
			set {
				add_global_event_listener_handler = value;
				if (add_global_event_listener_callback == null)
					add_global_event_listener_callback = new AddGlobalEventListenerNativeDelegate (AddGlobalEventListenerCallback);
				atksharp_util_override_add_global_event_listener (add_global_event_listener_callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RemoveListenerNativeDelegate (uint listener_id);

		static RemoveListenerDelegate remove_global_event_listener_handler;
		static RemoveListenerNativeDelegate remove_global_event_listener_callback;

		static void RemoveGlobalEventListenerCallback (uint listener_id)
		{
			try {
				remove_global_event_listener_handler (listener_id);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[DllImport("atksharpglue-3")]
		static extern void atksharp_util_override_remove_global_event_listener (RemoveListenerNativeDelegate cb);
		
		public delegate void RemoveListenerDelegate (uint listener_id);

		public static RemoveListenerDelegate RemoveGlobalEventListenerHandler {
			set {
				remove_global_event_listener_handler = value;
				if (remove_global_event_listener_callback == null)
					remove_global_event_listener_callback = new RemoveListenerNativeDelegate (RemoveGlobalEventListenerCallback);
				atksharp_util_override_remove_global_event_listener (remove_global_event_listener_callback);
			}
		}

		static RemoveListenerDelegate remove_key_event_listener_handler;
		static RemoveListenerNativeDelegate remove_key_event_listener_callback;

		static void RemoveKeyEventListenerCallback (uint listener_id)
		{
			try {
				remove_key_event_listener_handler (listener_id);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[DllImport("atksharpglue-3")]
		static extern void atksharp_util_override_remove_key_event_listener (RemoveListenerNativeDelegate cb);
		
		public static RemoveListenerDelegate RemoveKeyEventListenerHandler {
			set {
				remove_key_event_listener_handler = value;
				if (remove_key_event_listener_callback == null)
					remove_key_event_listener_callback = new RemoveListenerNativeDelegate (RemoveKeyEventListenerCallback);
				atksharp_util_override_remove_key_event_listener (remove_key_event_listener_callback);
			}
		}
	}
}
