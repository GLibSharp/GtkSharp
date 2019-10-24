// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IconFactory : GLib.Object {

		public IconFactory (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_new();

		public IconFactory () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IconFactory)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_icon_factory_new();
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
		static extern void gtk_icon_factory_add(IntPtr raw, IntPtr stock_id, IntPtr icon_set);

		[Obsolete]
		public void Add(string stock_id, Gtk.IconSet icon_set) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			gtk_icon_factory_add(Handle, native_stock_id, icon_set == null ? IntPtr.Zero : icon_set.Handle);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_factory_add_default(IntPtr raw);

		[Obsolete]
		public void AddDefault() {
			gtk_icon_factory_add_default(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_icon_factory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_lookup(IntPtr raw, IntPtr stock_id);

		[Obsolete]
		public Gtk.IconSet Lookup(string stock_id) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_icon_factory_lookup(Handle, native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_lookup_default(IntPtr stock_id);

		[Obsolete]
		public static Gtk.IconSet LookupDefault(string stock_id) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_icon_factory_lookup_default(native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_factory_remove_default(IntPtr raw);

		[Obsolete]
		public void RemoveDefault() {
			gtk_icon_factory_remove_default(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
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
