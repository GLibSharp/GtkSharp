// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	public partial class TestFundamentalSubObjectNoGetSetFunc : Regress.TestFundamentalObjectNoGetSetFunc {

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_sub_object_no_get_set_func_get_type();

		public static new GLib.GType GType {
			get {
				IntPtr raw_ret = regress_test_fundamental_sub_object_no_get_set_func_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public TestFundamentalSubObjectNoGetSetFunc(IntPtr raw) : base(raw) { }

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_sub_object_no_get_set_func_new(IntPtr data);

		public TestFundamentalSubObjectNoGetSetFunc(string data) {
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup(data);
			Raw = regress_test_fundamental_sub_object_no_get_set_func_new(native_data);
			GLib.Marshaller.Free(native_data);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct(Regress.TestFundamentalObjectNoGetSetFunc.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

		#endregion
	}
}