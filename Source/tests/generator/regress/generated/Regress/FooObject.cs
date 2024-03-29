// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FooObject : GLib.Object, Regress.IFooInterface {

		public FooObject (IntPtr raw) : base(raw) {}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_new();

		public FooObject () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FooObject)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = regress_foo_object_new();
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_new_as_super();

		public static FooObject NewAsSuper()
		{
			FooObject result = new FooObject (regress_foo_object_new_as_super());
			return result;
		}

		[GLib.Property ("string")]
		public string String {
			get {
				GLib.Value val = GetProperty ("string");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("string", val);
				val.Dispose ();
			}
		}

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_fooobject_get_parent_instance_offset ();

		static uint parent_instance_offset = regresssharp_regress_fooobject_get_parent_instance_offset ();
		public GLib.Object ParentInstance {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + parent_instance_offset);
					return GLib.Object.GetObject ((*raw_ptr));
				}
			}
		}

		public int SomeInt {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("some_int"));
					return (*raw_ptr);
				}
			}
		}

		[GLib.Signal("signal")]
		public event Regress.SignalHandler Signal {
			add {
				this.AddSignalHandler ("signal", value, typeof (Regress.SignalArgs));
			}
			remove {
				this.RemoveSignalHandler ("signal", value);
			}
		}

		static SignalNativeDelegate Signal_cb_delegate;
		static SignalNativeDelegate SignalVMCallback {
			get {
				if (Signal_cb_delegate == null)
					Signal_cb_delegate = new SignalNativeDelegate (Signal_cb);
				return Signal_cb_delegate;
			}
		}

		static void OverrideSignal (GLib.GType gtype)
		{
			OverrideSignal (gtype, SignalVMCallback);
		}

		static void OverrideSignal (GLib.GType gtype, SignalNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "signal", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr SignalNativeDelegate (IntPtr inst, IntPtr _object, IntPtr p0);

		static IntPtr Signal_cb (IntPtr inst, IntPtr _object, IntPtr p0)
		{
			try {
				FooObject __obj = GLib.Object.GetObject (inst, false) as FooObject;
				string __result;
				__result = __obj.OnSignal (GLib.Object.GetObject (_object), p0);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.FooObject), ConnectionMethod="OverrideSignal")]
		protected virtual string OnSignal (GLib.Object _object, IntPtr p0)
		{
			return InternalSignal (_object, p0);
		}

		private string InternalSignal (GLib.Object _object, IntPtr p0)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.String);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (_object);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (p0);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			string result = (string) ret;
			ret.Dispose ();
			return result;
		}

		static VirtualMethodNativeDelegate VirtualMethod_cb_delegate;
		static VirtualMethodNativeDelegate VirtualMethodVMCallback {
			get {
				if (VirtualMethod_cb_delegate == null)
					VirtualMethod_cb_delegate = new VirtualMethodNativeDelegate (VirtualMethod_cb);
				return VirtualMethod_cb_delegate;
			}
		}

		static void OverrideVirtualMethod (GLib.GType gtype)
		{
			OverrideVirtualMethod (gtype, VirtualMethodVMCallback);
		}

		static void OverrideVirtualMethod (GLib.GType gtype, VirtualMethodNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("virtual_method"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool VirtualMethodNativeDelegate (IntPtr inst, int first_param);

		static bool VirtualMethod_cb (IntPtr inst, int first_param)
		{
			try {
				FooObject __obj = GLib.Object.GetObject (inst, false) as FooObject;
				bool __result;
				__result = __obj.OnVirtualMethod (first_param);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.FooObject), ConnectionMethod="OverrideVirtualMethod")]
		protected virtual bool OnVirtualMethod (int first_param)
		{
			return InternalVirtualMethod (first_param);
		}

		private bool InternalVirtualMethod (int first_param)
		{
			VirtualMethodNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("virtual_method"));
				unmanaged = (VirtualMethodNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(VirtualMethodNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, first_param);
			return __result;
		}

		static ReadFnNativeDelegate ReadFn_cb_delegate;
		static ReadFnNativeDelegate ReadFnVMCallback {
			get {
				if (ReadFn_cb_delegate == null)
					ReadFn_cb_delegate = new ReadFnNativeDelegate (ReadFn_cb);
				return ReadFn_cb_delegate;
			}
		}

		static void OverrideReadFn (GLib.GType gtype)
		{
			OverrideReadFn (gtype, ReadFnVMCallback);
		}

		static void OverrideReadFn (GLib.GType gtype, ReadFnNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("read_fn"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReadFnNativeDelegate (IntPtr inst, int offset, int length);

		static void ReadFn_cb (IntPtr inst, int offset, int length)
		{
			try {
				FooObject __obj = GLib.Object.GetObject (inst, false) as FooObject;
				__obj.OnReadFn (offset, length);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.FooObject), ConnectionMethod="OverrideReadFn")]
		protected virtual void OnReadFn (int offset, int length)
		{
			InternalReadFn (offset, length);
		}

		private void InternalReadFn (int offset, int length)
		{
			ReadFnNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("read_fn"));
				unmanaged = (ReadFnNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ReadFnNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, offset, length);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("virtual_method"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // virtual_method
							, null
							, "read_fn"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("read_fn"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // read_fn
							, "virtual_method"
							, "_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _reserved
							, "read_fn"
							, null
							, (long) Marshal.OffsetOf(typeof(RegressFooObject__reservedAlign), "_reserved")
							, 0
							),
					});

				return _class_abi;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RegressFooObject__reservedAlign
		{
			sbyte f1;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			private IntPtr[] _reserved;
		}


		// End of the ABI representation.

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_foo_object_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_get_default();

		public static Regress.FooSubobject Default { 
			get {
				IntPtr raw_ret = regress_foo_object_get_default();
				Regress.FooSubobject ret = GLib.Object.GetObject(raw_ret) as Regress.FooSubobject;
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_foo_object_static_meth();

		public static int StaticMeth() {
			int raw_ret = regress_foo_object_static_meth();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_append_new_stack_layer(IntPtr raw, int x);

		public Regress.FooOtherObject AppendNewStackLayer(int x) {
			IntPtr raw_ret = regress_foo_object_append_new_stack_layer(Handle, x);
			Regress.FooOtherObject ret = GLib.Object.GetObject(raw_ret) as Regress.FooOtherObject;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_dup_name(IntPtr raw);

		public string DupName() {
			IntPtr raw_ret = regress_foo_object_dup_name(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_object_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = regress_foo_object_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_object_is_it_time_yet(IntPtr raw, IntPtr time);

		public void IsItTimeYet(long time) {
			regress_foo_object_is_it_time_yet(Handle, new IntPtr (time));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_object_read(IntPtr raw, int offset, int length);

		public void Read(int offset, int length) {
			regress_foo_object_read(Handle, offset, length);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_object_various(IntPtr raw, IntPtr data, IntPtr some_type);

		public void Various(IntPtr data, GLib.GType some_type) {
			regress_foo_object_various(Handle, data, some_type.Val);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool regress_foo_object_virtual_method(IntPtr raw, int first_param);

		public bool VirtualMethod(int first_param) {
			bool raw_ret = regress_foo_object_virtual_method(Handle, first_param);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_interface_do_regress_foo(IntPtr raw, int x);

		public void DoRegressFoo(int x) {
			regress_foo_interface_do_regress_foo(Handle, x);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("some_int"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(int)) // some_int
							, null
							, null
							, (long) Marshal.OffsetOf(typeof(RegressFooObject_some_intAlign), "some_int")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RegressFooObject_some_intAlign
		{
			sbyte f1;
			private int some_int;
		}


		// End of the ABI representation.

#endregion
	}
}
