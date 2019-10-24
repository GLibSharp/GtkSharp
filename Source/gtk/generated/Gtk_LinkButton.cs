// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LinkButton : Gtk.Button {

		public LinkButton (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_link_button_new(IntPtr uri);

		public LinkButton (string uri) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LinkButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("uri");
				vals.Add (new GLib.Value (uri));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			Raw = gtk_link_button_new(native_uri);
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_link_button_new_with_label(IntPtr uri, IntPtr label);

		public LinkButton (string uri, string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LinkButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("uri");
				vals.Add (new GLib.Value (uri));
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_link_button_new_with_label(native_uri, native_label);
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_link_button_get_uri(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_link_button_set_uri(IntPtr raw, IntPtr uri);

		[GLib.Property ("uri")]
		public string Uri {
			get  {
				IntPtr raw_ret = gtk_link_button_get_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_link_button_set_uri(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_link_button_get_visited(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_link_button_set_visited(IntPtr raw, bool visited);

		[GLib.Property ("visited")]
		public bool Visited {
			get  {
				bool raw_ret = gtk_link_button_get_visited(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_link_button_set_visited(Handle, value);
			}
		}

		[GLib.Signal("activate-link")]
		public event Gtk.ActivateLinkHandler ActivateLink {
			add {
				this.AddSignalHandler ("activate-link", value, typeof (Gtk.ActivateLinkArgs));
			}
			remove {
				this.RemoveSignalHandler ("activate-link", value);
			}
		}

		static ActivateLinkNativeDelegate ActivateLink_cb_delegate;
		static ActivateLinkNativeDelegate ActivateLinkVMCallback {
			get {
				if (ActivateLink_cb_delegate == null)
					ActivateLink_cb_delegate = new ActivateLinkNativeDelegate (ActivateLink_cb);
				return ActivateLink_cb_delegate;
			}
		}

		static void OverrideActivateLink (GLib.GType gtype)
		{
			OverrideActivateLink (gtype, ActivateLinkVMCallback);
		}

		static void OverrideActivateLink (GLib.GType gtype, ActivateLinkNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate_link"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ActivateLinkNativeDelegate (IntPtr inst);

		static bool ActivateLink_cb (IntPtr inst)
		{
			try {
				LinkButton __obj = GLib.Object.GetObject (inst, false) as LinkButton;
				bool __result;
				__result = __obj.OnActivateLink ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.LinkButton), ConnectionMethod="OverrideActivateLink")]
		protected virtual bool OnActivateLink ()
		{
			return InternalActivateLink ();
		}

		private bool InternalActivateLink ()
		{
			ActivateLinkNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("activate_link"));
				unmanaged = (ActivateLinkNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActivateLinkNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("activate_link"
							, Gtk.Button.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // activate_link
							, null
							, "_gtk_padding1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_padding1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_padding1
							, "activate_link"
							, "_gtk_padding2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_padding2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_padding2
							, "_gtk_padding1"
							, "_gtk_padding3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_padding3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_padding3
							, "_gtk_padding2"
							, "_gtk_padding4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_padding4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_padding4
							, "_gtk_padding3"
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
		static extern IntPtr gtk_link_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_link_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Button.abi_info.Fields
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
