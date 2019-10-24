// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionGroup : GLib.Object {

		public ActionGroup (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_new(IntPtr name);

		public ActionGroup (string name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ActionGroup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gtk_action_group_new(native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_get_name(IntPtr raw);

		[Obsolete]
		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = gtk_action_group_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_action_group_get_sensitive(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_set_sensitive(IntPtr raw, bool sensitive);

		[Obsolete]
		[GLib.Property ("sensitive")]
		public bool Sensitive {
			get  {
				bool raw_ret = gtk_action_group_get_sensitive(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_action_group_set_sensitive(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_action_group_get_visible(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_set_visible(IntPtr raw, bool visible);

		[Obsolete]
		[GLib.Property ("visible")]
		public bool Visible {
			get  {
				bool raw_ret = gtk_action_group_get_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_action_group_set_visible(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_get_accel_group(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_set_accel_group(IntPtr raw, IntPtr accel_group);

		[Obsolete]
		[GLib.Property ("accel-group")]
		public Gtk.AccelGroup AccelGroup {
			get  {
				IntPtr raw_ret = gtk_action_group_get_accel_group(Handle);
				Gtk.AccelGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelGroup;
				return ret;
			}
			set  {
				gtk_action_group_set_accel_group(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("disconnect-proxy")]
		public event Gtk.DisconnectProxyHandler DisconnectProxy {
			add {
				this.AddSignalHandler ("disconnect-proxy", value, typeof (Gtk.DisconnectProxyArgs));
			}
			remove {
				this.RemoveSignalHandler ("disconnect-proxy", value);
			}
		}

		[GLib.Signal("pre-activate")]
		public event Gtk.PreActivateHandler PreActivate {
			add {
				this.AddSignalHandler ("pre-activate", value, typeof (Gtk.PreActivateArgs));
			}
			remove {
				this.RemoveSignalHandler ("pre-activate", value);
			}
		}

		[GLib.Signal("connect-proxy")]
		public event Gtk.ConnectProxyHandler ConnectProxy {
			add {
				this.AddSignalHandler ("connect-proxy", value, typeof (Gtk.ConnectProxyArgs));
			}
			remove {
				this.RemoveSignalHandler ("connect-proxy", value);
			}
		}

		[GLib.Signal("post-activate")]
		public event Gtk.PostActivateHandler PostActivate {
			add {
				this.AddSignalHandler ("post-activate", value, typeof (Gtk.PostActivateArgs));
			}
			remove {
				this.RemoveSignalHandler ("post-activate", value);
			}
		}

		static ConnectProxyNativeDelegate ConnectProxy_cb_delegate;
		static ConnectProxyNativeDelegate ConnectProxyVMCallback {
			get {
				if (ConnectProxy_cb_delegate == null)
					ConnectProxy_cb_delegate = new ConnectProxyNativeDelegate (ConnectProxy_cb);
				return ConnectProxy_cb_delegate;
			}
		}

		static void OverrideConnectProxy (GLib.GType gtype)
		{
			OverrideConnectProxy (gtype, ConnectProxyVMCallback);
		}

		static void OverrideConnectProxy (GLib.GType gtype, ConnectProxyNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "connect-proxy", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectProxyNativeDelegate (IntPtr inst, IntPtr action, IntPtr proxy);

		static void ConnectProxy_cb (IntPtr inst, IntPtr action, IntPtr proxy)
		{
			try {
				ActionGroup __obj = GLib.Object.GetObject (inst, false) as ActionGroup;
				__obj.OnConnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ActionGroup), ConnectionMethod="OverrideConnectProxy")]
		protected virtual void OnConnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			InternalConnectProxy (action, proxy);
		}

		private void InternalConnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (proxy);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static DisconnectProxyNativeDelegate DisconnectProxy_cb_delegate;
		static DisconnectProxyNativeDelegate DisconnectProxyVMCallback {
			get {
				if (DisconnectProxy_cb_delegate == null)
					DisconnectProxy_cb_delegate = new DisconnectProxyNativeDelegate (DisconnectProxy_cb);
				return DisconnectProxy_cb_delegate;
			}
		}

		static void OverrideDisconnectProxy (GLib.GType gtype)
		{
			OverrideDisconnectProxy (gtype, DisconnectProxyVMCallback);
		}

		static void OverrideDisconnectProxy (GLib.GType gtype, DisconnectProxyNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "disconnect-proxy", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DisconnectProxyNativeDelegate (IntPtr inst, IntPtr action, IntPtr proxy);

		static void DisconnectProxy_cb (IntPtr inst, IntPtr action, IntPtr proxy)
		{
			try {
				ActionGroup __obj = GLib.Object.GetObject (inst, false) as ActionGroup;
				__obj.OnDisconnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ActionGroup), ConnectionMethod="OverrideDisconnectProxy")]
		protected virtual void OnDisconnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			InternalDisconnectProxy (action, proxy);
		}

		private void InternalDisconnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (proxy);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PreActivateNativeDelegate PreActivate_cb_delegate;
		static PreActivateNativeDelegate PreActivateVMCallback {
			get {
				if (PreActivate_cb_delegate == null)
					PreActivate_cb_delegate = new PreActivateNativeDelegate (PreActivate_cb);
				return PreActivate_cb_delegate;
			}
		}

		static void OverridePreActivate (GLib.GType gtype)
		{
			OverridePreActivate (gtype, PreActivateVMCallback);
		}

		static void OverridePreActivate (GLib.GType gtype, PreActivateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "pre-activate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PreActivateNativeDelegate (IntPtr inst, IntPtr action);

		static void PreActivate_cb (IntPtr inst, IntPtr action)
		{
			try {
				ActionGroup __obj = GLib.Object.GetObject (inst, false) as ActionGroup;
				__obj.OnPreActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ActionGroup), ConnectionMethod="OverridePreActivate")]
		protected virtual void OnPreActivate (Gtk.Action action)
		{
			InternalPreActivate (action);
		}

		private void InternalPreActivate (Gtk.Action action)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PostActivateNativeDelegate PostActivate_cb_delegate;
		static PostActivateNativeDelegate PostActivateVMCallback {
			get {
				if (PostActivate_cb_delegate == null)
					PostActivate_cb_delegate = new PostActivateNativeDelegate (PostActivate_cb);
				return PostActivate_cb_delegate;
			}
		}

		static void OverridePostActivate (GLib.GType gtype)
		{
			OverridePostActivate (gtype, PostActivateVMCallback);
		}

		static void OverridePostActivate (GLib.GType gtype, PostActivateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "post-activate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PostActivateNativeDelegate (IntPtr inst, IntPtr action);

		static void PostActivate_cb (IntPtr inst, IntPtr action)
		{
			try {
				ActionGroup __obj = GLib.Object.GetObject (inst, false) as ActionGroup;
				__obj.OnPostActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ActionGroup), ConnectionMethod="OverridePostActivate")]
		protected virtual void OnPostActivate (Gtk.Action action)
		{
			InternalPostActivate (action);
		}

		private void InternalPostActivate (Gtk.Action action)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static GetActionNativeDelegate GetAction_cb_delegate;
		static GetActionNativeDelegate GetActionVMCallback {
			get {
				if (GetAction_cb_delegate == null)
					GetAction_cb_delegate = new GetActionNativeDelegate (GetAction_cb);
				return GetAction_cb_delegate;
			}
		}

		static void OverrideGetAction (GLib.GType gtype)
		{
			OverrideGetAction (gtype, GetActionVMCallback);
		}

		static void OverrideGetAction (GLib.GType gtype, GetActionNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_action"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetActionNativeDelegate (IntPtr inst, IntPtr action_name);

		static IntPtr GetAction_cb (IntPtr inst, IntPtr action_name)
		{
			try {
				ActionGroup __obj = GLib.Object.GetObject (inst, false) as ActionGroup;
				Gtk.Action __result;
				__result = __obj.OnGetAction (GLib.Marshaller.Utf8PtrToString (action_name));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ActionGroup), ConnectionMethod="OverrideGetAction")]
		protected virtual Gtk.Action OnGetAction (string action_name)
		{
			return InternalGetAction (action_name);
		}

		private Gtk.Action InternalGetAction (string action_name)
		{
			GetActionNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_action"));
				unmanaged = (GetActionNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetActionNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr __result = unmanaged (this.Handle, native_action_name);
			GLib.Marshaller.Free (native_action_name);
			return GLib.Object.GetObject(__result) as Gtk.Action;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_action"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_action
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "get_action"
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
		static extern void gtk_action_group_add_action(IntPtr raw, IntPtr action);

		[Obsolete]
		public void Add(Gtk.Action action) {
			gtk_action_group_add_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_add_action_with_accel(IntPtr raw, IntPtr action, IntPtr accelerator);

		[Obsolete]
		public void Add(Gtk.Action action, string accelerator) {
			IntPtr native_accelerator = GLib.Marshaller.StringToPtrGStrdup (accelerator);
			gtk_action_group_add_action_with_accel(Handle, action == null ? IntPtr.Zero : action.Handle, native_accelerator);
			GLib.Marshaller.Free (native_accelerator);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_get_action(IntPtr raw, IntPtr action_name);

		[Obsolete]
		public Gtk.Action GetAction(string action_name) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr raw_ret = gtk_action_group_get_action(Handle, native_action_name);
			Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
			GLib.Marshaller.Free (native_action_name);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_action_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_remove_action(IntPtr raw, IntPtr action);

		[Obsolete]
		public void Remove(Gtk.Action action) {
			gtk_action_group_remove_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_set_translate_func(IntPtr raw, GtkSharp.TranslateFuncNative func, IntPtr data, GLib.DestroyNotify notify);

		[Obsolete]
		public Gtk.TranslateFunc TranslateFunc { 
			set {
				GtkSharp.TranslateFuncWrapper value_wrapper = new GtkSharp.TranslateFuncWrapper (value);
				IntPtr data;
				GLib.DestroyNotify notify;
				if (value == null) {
					data = IntPtr.Zero;
					notify = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value_wrapper);
					notify = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_action_group_set_translate_func(Handle, value_wrapper.NativeDelegate, data, notify);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_group_set_translation_domain(IntPtr raw, IntPtr domain);

		[Obsolete]
		public string TranslationDomain { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_action_group_set_translation_domain(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_group_translate_string(IntPtr raw, IntPtr str1ng);

		[Obsolete]
		public string TranslateString(string str1ng) {
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			IntPtr raw_ret = gtk_action_group_translate_string(Handle, native_str1ng);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_str1ng);
			return ret;
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
