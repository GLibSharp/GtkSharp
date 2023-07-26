// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TabArray : GLib.Opaque {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_tab_array_copy(IntPtr raw);

		public Pango.TabArray Copy() {
			IntPtr raw_ret = pango_tab_array_copy(Handle);
			Pango.TabArray ret = raw_ret == IntPtr.Zero ? null : (Pango.TabArray) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.TabArray), true);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_tab_array_get_positions_in_pixels(IntPtr raw);

		public bool PositionsInPixels { 
			get {
				bool raw_ret = pango_tab_array_get_positions_in_pixels(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_tab_array_get_size(IntPtr raw);

		public int Size { 
			get {
				int raw_ret = pango_tab_array_get_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_tab_array_get_tab(IntPtr raw, int tab_index, out int alignment, out int location);

		public void GetTab(int tab_index, out Pango.TabAlign alignment, out int location) {
			int native_alignment;
			pango_tab_array_get_tab(Handle, tab_index, out native_alignment, out location);
			alignment = (Pango.TabAlign) native_alignment;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_tab_array_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_tab_array_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_tab_array_resize(IntPtr raw, int new_size);

		public void Resize(int new_size) {
			pango_tab_array_resize(Handle, new_size);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_tab_array_set_tab(IntPtr raw, int tab_index, int alignment, int location);

		public void SetTab(int tab_index, Pango.TabAlign alignment, int location) {
			pango_tab_array_set_tab(Handle, tab_index, (int) alignment, location);
		}

		public TabArray(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_tab_array_new(int initial_size, bool positions_in_pixels);

		public TabArray (int initial_size, bool positions_in_pixels) 
		{
			Raw = pango_tab_array_new(initial_size, positions_in_pixels);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_tab_array_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			pango_tab_array_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return pango_tab_array_free;
			}
		}

		[Obsolete("Pango.TabArray is now freed automatically")]
		public void Free () {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
