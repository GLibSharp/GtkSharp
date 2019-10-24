// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UIManager : GLib.Object {

		public UIManager (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_new();

		public UIManager () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UIManager)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_ui_manager_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_ui_manager_get_add_tearoffs(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_set_add_tearoffs(IntPtr raw, bool add_tearoffs);

		[Obsolete]
		[GLib.Property ("add-tearoffs")]
		public bool AddTearoffs {
			get  {
				bool raw_ret = gtk_ui_manager_get_add_tearoffs(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_ui_manager_set_add_tearoffs(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_ui(IntPtr raw);

		[Obsolete]
		[GLib.Property ("ui")]
		public string Ui {
			get  {
				IntPtr raw_ret = gtk_ui_manager_get_ui(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
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

		[GLib.Signal("pre-activate")]
		public event Gtk.PreActivateHandler PreActivate {
			add {
				this.AddSignalHandler ("pre-activate", value, typeof (Gtk.PreActivateArgs));
			}
			remove {
				this.RemoveSignalHandler ("pre-activate", value);
			}
		}

		[GLib.Signal("add-widget")]
		public event Gtk.AddWidgetHandler AddWidget {
			add {
				this.AddSignalHandler ("add-widget", value, typeof (Gtk.AddWidgetArgs));
			}
			remove {
				this.RemoveSignalHandler ("add-widget", value);
			}
		}

		[GLib.Signal("actions-changed")]
		public event System.EventHandler ActionsChanged {
			add {
				this.AddSignalHandler ("actions-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("actions-changed", value);
			}
		}

		static AddWidgetNativeDelegate AddWidget_cb_delegate;
		static AddWidgetNativeDelegate AddWidgetVMCallback {
			get {
				if (AddWidget_cb_delegate == null)
					AddWidget_cb_delegate = new AddWidgetNativeDelegate (AddWidget_cb);
				return AddWidget_cb_delegate;
			}
		}

		static void OverrideAddWidget (GLib.GType gtype)
		{
			OverrideAddWidget (gtype, AddWidgetVMCallback);
		}

		static void OverrideAddWidget (GLib.GType gtype, AddWidgetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("add_widget"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AddWidgetNativeDelegate (IntPtr inst, IntPtr widget);

		static void AddWidget_cb (IntPtr inst, IntPtr widget)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnAddWidget (GLib.Object.GetObject(widget) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideAddWidget")]
		protected virtual void OnAddWidget (Gtk.Widget widget)
		{
			InternalAddWidget (widget);
		}

		private void InternalAddWidget (Gtk.Widget widget)
		{
			AddWidgetNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("add_widget"));
				unmanaged = (AddWidgetNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AddWidgetNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, widget == null ? IntPtr.Zero : widget.Handle);
		}

		static ActionsChangedNativeDelegate ActionsChanged_cb_delegate;
		static ActionsChangedNativeDelegate ActionsChangedVMCallback {
			get {
				if (ActionsChanged_cb_delegate == null)
					ActionsChanged_cb_delegate = new ActionsChangedNativeDelegate (ActionsChanged_cb);
				return ActionsChanged_cb_delegate;
			}
		}

		static void OverrideActionsChanged (GLib.GType gtype)
		{
			OverrideActionsChanged (gtype, ActionsChangedVMCallback);
		}

		static void OverrideActionsChanged (GLib.GType gtype, ActionsChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("actions_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionsChangedNativeDelegate (IntPtr inst);

		static void ActionsChanged_cb (IntPtr inst)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnActionsChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideActionsChanged")]
		protected virtual void OnActionsChanged ()
		{
			InternalActionsChanged ();
		}

		private void InternalActionsChanged ()
		{
			ActionsChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("actions_changed"));
				unmanaged = (ActionsChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActionsChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
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
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("connect_proxy"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectProxyNativeDelegate (IntPtr inst, IntPtr action, IntPtr proxy);

		static void ConnectProxy_cb (IntPtr inst, IntPtr action, IntPtr proxy)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnConnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideConnectProxy")]
		protected virtual void OnConnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			InternalConnectProxy (action, proxy);
		}

		private void InternalConnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			ConnectProxyNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("connect_proxy"));
				unmanaged = (ConnectProxyNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ConnectProxyNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, action == null ? IntPtr.Zero : action.Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
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
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("disconnect_proxy"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DisconnectProxyNativeDelegate (IntPtr inst, IntPtr action, IntPtr proxy);

		static void DisconnectProxy_cb (IntPtr inst, IntPtr action, IntPtr proxy)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnDisconnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideDisconnectProxy")]
		protected virtual void OnDisconnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			InternalDisconnectProxy (action, proxy);
		}

		private void InternalDisconnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			DisconnectProxyNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("disconnect_proxy"));
				unmanaged = (DisconnectProxyNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DisconnectProxyNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, action == null ? IntPtr.Zero : action.Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
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
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("pre_activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PreActivateNativeDelegate (IntPtr inst, IntPtr action);

		static void PreActivate_cb (IntPtr inst, IntPtr action)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnPreActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverridePreActivate")]
		protected virtual void OnPreActivate (Gtk.Action action)
		{
			InternalPreActivate (action);
		}

		private void InternalPreActivate (Gtk.Action action)
		{
			PreActivateNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("pre_activate"));
				unmanaged = (PreActivateNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(PreActivateNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, action == null ? IntPtr.Zero : action.Handle);
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
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("post_activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PostActivateNativeDelegate (IntPtr inst, IntPtr action);

		static void PostActivate_cb (IntPtr inst, IntPtr action)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				__obj.OnPostActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverridePostActivate")]
		protected virtual void OnPostActivate (Gtk.Action action)
		{
			InternalPostActivate (action);
		}

		private void InternalPostActivate (Gtk.Action action)
		{
			PostActivateNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("post_activate"));
				unmanaged = (PostActivateNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(PostActivateNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		static GetWidgetNativeDelegate GetWidget_cb_delegate;
		static GetWidgetNativeDelegate GetWidgetVMCallback {
			get {
				if (GetWidget_cb_delegate == null)
					GetWidget_cb_delegate = new GetWidgetNativeDelegate (GetWidget_cb);
				return GetWidget_cb_delegate;
			}
		}

		static void OverrideGetWidget (GLib.GType gtype)
		{
			OverrideGetWidget (gtype, GetWidgetVMCallback);
		}

		static void OverrideGetWidget (GLib.GType gtype, GetWidgetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_widget"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetWidgetNativeDelegate (IntPtr inst, IntPtr path);

		static IntPtr GetWidget_cb (IntPtr inst, IntPtr path)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				Gtk.Widget __result;
				__result = __obj.OnGetWidget (GLib.Marshaller.Utf8PtrToString (path));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideGetWidget")]
		protected virtual Gtk.Widget OnGetWidget (string path)
		{
			return InternalGetWidget (path);
		}

		private Gtk.Widget InternalGetWidget (string path)
		{
			GetWidgetNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_widget"));
				unmanaged = (GetWidgetNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetWidgetNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr __result = unmanaged (this.Handle, native_path);
			GLib.Marshaller.Free (native_path);
			return GLib.Object.GetObject(__result) as Gtk.Widget;
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
		delegate IntPtr GetActionNativeDelegate (IntPtr inst, IntPtr path);

		static IntPtr GetAction_cb (IntPtr inst, IntPtr path)
		{
			try {
				UIManager __obj = GLib.Object.GetObject (inst, false) as UIManager;
				Gtk.Action __result;
				__result = __obj.OnGetAction (GLib.Marshaller.Utf8PtrToString (path));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideGetAction")]
		protected virtual Gtk.Action OnGetAction (string path)
		{
			return InternalGetAction (path);
		}

		private Gtk.Action InternalGetAction (string path)
		{
			GetActionNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_action"));
				unmanaged = (GetActionNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetActionNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr __result = unmanaged (this.Handle, native_path);
			GLib.Marshaller.Free (native_path);
			return GLib.Object.GetObject(__result) as Gtk.Action;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("add_widget"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // add_widget
							, null
							, "actions_changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("actions_changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // actions_changed
							, "add_widget"
							, "connect_proxy"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("connect_proxy"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // connect_proxy
							, "actions_changed"
							, "disconnect_proxy"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("disconnect_proxy"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // disconnect_proxy
							, "connect_proxy"
							, "pre_activate"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pre_activate"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pre_activate
							, "disconnect_proxy"
							, "post_activate"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("post_activate"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // post_activate
							, "pre_activate"
							, "get_widget"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_widget"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_widget
							, "post_activate"
							, "get_action"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_action"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_action
							, "get_widget"
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
		static extern void gtk_ui_manager_add_ui(IntPtr raw, uint merge_id, IntPtr path, IntPtr name, IntPtr action, int type, bool top);

		[Obsolete]
		public void AddUi(uint merge_id, string path, string name, string action, Gtk.UIManagerItemType type, bool top) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_action = GLib.Marshaller.StringToPtrGStrdup (action);
			gtk_ui_manager_add_ui(Handle, merge_id, native_path, native_name, native_action, (int) type, top);
			GLib.Marshaller.Free (native_path);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_action);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint gtk_ui_manager_add_ui_from_file(IntPtr raw, IntPtr filename, out IntPtr error);

		[Obsolete]
		public unsafe uint AddUiFromFile(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			uint raw_ret = gtk_ui_manager_add_ui_from_file(Handle, native_filename, out error);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint gtk_ui_manager_add_ui_from_string(IntPtr raw, IntPtr buffer, IntPtr length, out IntPtr error);

		[Obsolete]
		public unsafe uint AddUiFromString(string buffer) {
			IntPtr native_buffer = GLib.Marshaller.StringToPtrGStrdup (buffer);
			IntPtr error = IntPtr.Zero;
			uint raw_ret = gtk_ui_manager_add_ui_from_string(Handle, native_buffer, new IntPtr ((long) System.Text.Encoding.UTF8.GetByteCount (buffer)), out error);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_buffer);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_ensure_update(IntPtr raw);

		[Obsolete]
		public void EnsureUpdate() {
			gtk_ui_manager_ensure_update(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_accel_group(IntPtr raw);

		[Obsolete]
		public Gtk.AccelGroup AccelGroup { 
			get {
				IntPtr raw_ret = gtk_ui_manager_get_accel_group(Handle);
				Gtk.AccelGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelGroup;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_action(IntPtr raw, IntPtr path);

		[Obsolete]
		public Gtk.Action GetAction(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gtk_ui_manager_get_action(Handle, native_path);
			Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_ui_manager_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_widget(IntPtr raw, IntPtr path);

		[Obsolete]
		public Gtk.Widget GetWidget(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gtk_ui_manager_get_widget(Handle, native_path);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_insert_action_group(IntPtr raw, IntPtr action_group, int pos);

		[Obsolete]
		public void InsertActionGroup(Gtk.ActionGroup action_group, int pos) {
			gtk_ui_manager_insert_action_group(Handle, action_group == null ? IntPtr.Zero : action_group.Handle, pos);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_remove_action_group(IntPtr raw, IntPtr action_group);

		[Obsolete]
		public void RemoveActionGroup(Gtk.ActionGroup action_group) {
			gtk_ui_manager_remove_action_group(Handle, action_group == null ? IntPtr.Zero : action_group.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_remove_ui(IntPtr raw, uint merge_id);

		[Obsolete]
		public void RemoveUi(uint merge_id) {
			gtk_ui_manager_remove_ui(Handle, merge_id);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("private_data"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // private_data
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
