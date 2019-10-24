// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextMark : GLib.Object {

		public TextMark (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_mark_new(IntPtr name, bool left_gravity);

		public TextMark (string name, bool left_gravity) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TextMark)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("left_gravity");
				vals.Add (new GLib.Value (left_gravity));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gtk_text_mark_new(native_name, left_gravity);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_mark_get_name(IntPtr raw);

		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = gtk_text_mark_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_text_mark_get_left_gravity(IntPtr raw);

		[GLib.Property ("left-gravity")]
		public bool LeftGravity {
			get  {
				bool raw_ret = gtk_text_mark_get_left_gravity(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_mark_get_buffer(IntPtr raw);

		public Gtk.TextBuffer Buffer { 
			get {
				IntPtr raw_ret = gtk_text_mark_get_buffer(Handle);
				Gtk.TextBuffer ret = GLib.Object.GetObject(raw_ret) as Gtk.TextBuffer;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_text_mark_get_deleted(IntPtr raw);

		public bool Deleted { 
			get {
				bool raw_ret = gtk_text_mark_get_deleted(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_mark_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_text_mark_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_text_mark_get_visible(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_text_mark_set_visible(IntPtr raw, bool setting);

		public bool Visible { 
			get {
				bool raw_ret = gtk_text_mark_get_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_text_mark_set_visible(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("segment"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // segment
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
