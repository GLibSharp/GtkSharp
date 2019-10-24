// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ModelMenuItem : Gtk.CheckMenuItem {

		public ModelMenuItem (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_model_menu_item_new();

		public ModelMenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ModelMenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_model_menu_item_new();
		}

		[GLib.Property ("action-role")]
		public Gtk.MenuTrackerItemRole ActionRole {
			get {
				GLib.Value val = GetProperty ("action-role");
				Gtk.MenuTrackerItemRole ret = (Gtk.MenuTrackerItemRole) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("action-role", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("icon")]
		public GLib.IIcon Icon {
			get {
				GLib.Value val = GetProperty ("icon");
				GLib.IIcon ret = GLib.IconAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				GLib.Value val = GetProperty ("text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("toggled")]
		public bool Toggled {
			get {
				GLib.Value val = GetProperty ("toggled");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("toggled", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("accel")]
		public string Accel {
			get {
				GLib.Value val = GetProperty ("accel");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("accel", val);
				val.Dispose ();
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_model_menu_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_model_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
