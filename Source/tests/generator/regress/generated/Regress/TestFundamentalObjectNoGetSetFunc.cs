// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	public partial class TestFundamentalObjectNoGetSetFunc : GLib.Opaque {

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_object_no_get_set_func_get_data(IntPtr raw);

		public string Data {
			get {
				IntPtr raw_ret = regress_test_fundamental_object_no_get_set_func_get_data(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_object_no_get_set_func_get_type();

		public static GLib.GType GType {
			get {
				IntPtr raw_ret = regress_test_fundamental_object_no_get_set_func_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_fundamental_object_no_get_set_func_make_compatible_with_fundamental_sub_object();

		public static void MakeCompatibleWithFundamentalSubObject() {
			regress_test_fundamental_object_no_get_set_func_make_compatible_with_fundamental_sub_object();
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_object_no_get_set_func_new(IntPtr data);

		public TestFundamentalObjectNoGetSetFunc(string data) {
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup(data);
			Raw = regress_test_fundamental_object_no_get_set_func_new(native_data);
			GLib.Marshaller.Free(native_data);
		}

		public TestFundamentalObjectNoGetSetFunc(IntPtr raw) : base(raw) { }

		protected TestFundamentalObjectNoGetSetFunc() : base() { }

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_object_ref(IntPtr raw);

		protected override void Ref(IntPtr raw) {
			if (!Owned) {
				regress_test_fundamental_object_ref(raw);
				Owned = true;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_fundamental_object_unref(IntPtr raw);

		protected override void Unref(IntPtr raw) {
			if (Owned) {
				regress_test_fundamental_object_unref(raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return regress_test_fundamental_object_unref;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct(new List<GLib.AbiField>{
						new GLib.AbiField("fundamental_object"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fundamental_object
							, null
							, "data"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("data"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // data
							, "fundamental_object"
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