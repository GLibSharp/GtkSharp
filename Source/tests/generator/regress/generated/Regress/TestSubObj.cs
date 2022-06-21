// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TestSubObj : Regress.TestObj, Regress.ITestInterface {

		public TestSubObj (IntPtr raw) : base(raw) {}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_sub_obj_new();

		public TestSubObj () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TestSubObj)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = regress_test_sub_obj_new();
		}

		[GLib.Property ("boolean")]
		public bool Boolean {
			get {
				GLib.Value val = GetProperty ("boolean");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("boolean", val);
				val.Dispose ();
			}
		}

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_testsubobj_get_parent_instance_offset ();

		static uint parent_instance_offset = regresssharp_regress_testsubobj_get_parent_instance_offset ();
		public Regress.TestObj ParentInstance {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + parent_instance_offset);
					return GLib.Object.GetObject((*raw_ptr)) as Regress.TestObj;
				}
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_sub_obj_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_test_sub_obj_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_test_sub_obj_instance_method(IntPtr raw);

		public new int InstanceMethod() {
			int raw_ret = regress_test_sub_obj_instance_method(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_sub_obj_unset_bare(IntPtr raw);

		public void UnsetBare() {
			regress_test_sub_obj_unset_bare(Handle);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_interface_emit_signal(IntPtr raw);

		public void EmitSignal() {
			regress_test_interface_emit_signal(Handle);
		}

		[GLib.Property ("number")]
		public int Number {
			get {
				GLib.Value val = implementor.GetProperty ("number");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				implementor.SetProperty("number", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("interface-signal")]
		public event Regress.InterfaceSignalHandler InterfaceSignal {
			add {
				this.AddSignalHandler ("interface-signal", value, typeof (Regress.InterfaceSignalArgs));
			}
			remove {
				this.RemoveSignalHandler ("interface-signal", value);
			}
		}

		static InterfaceSignalNativeDelegate InterfaceSignal_cb_delegate;
		static InterfaceSignalNativeDelegate InterfaceSignalVMCallback {
			get {
				if (InterfaceSignal_cb_delegate == null)
					InterfaceSignal_cb_delegate = new InterfaceSignalNativeDelegate (InterfaceSignal_cb);
				return InterfaceSignal_cb_delegate;
			}
		}

		static void OverrideInterfaceSignal (GLib.GType gtype)
		{
			OverrideInterfaceSignal (gtype, InterfaceSignalVMCallback);
		}

		static void OverrideInterfaceSignal (GLib.GType gtype, InterfaceSignalNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "interface-signal", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void InterfaceSignalNativeDelegate (IntPtr inst, int ptr);

		static void InterfaceSignal_cb (IntPtr inst, int ptr)
		{
			try {
				Regress.TestSubObj __obj = GLib.Object.GetObject (inst, false) as Regress.TestSubObj;
				__obj.OnInterfaceSignal (ptr);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.TestSubObj), ConnectionMethod="OverrideInterfaceSignal")]
		protected virtual void OnInterfaceSignal (int ptr)
		{
			InternalInterfaceSignal (ptr);
		}

		private void InternalInterfaceSignal (int ptr)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (ptr);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

#endregion
	}
}
