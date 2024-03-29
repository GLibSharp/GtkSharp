// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LayoutIter : GLib.Opaque {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_iter_at_last_line(IntPtr raw);

		public bool AtLastLine() {
			bool raw_ret = pango_layout_iter_at_last_line(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_copy(IntPtr raw);

		public Pango.LayoutIter Copy() {
			IntPtr raw_ret = pango_layout_iter_copy(Handle);
			Pango.LayoutIter ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutIter) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutIter), true);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_layout_iter_get_baseline(IntPtr raw);

		public int Baseline { 
			get {
				int raw_ret = pango_layout_iter_get_baseline(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_char_extents(IntPtr raw, IntPtr logical_rect);

		public Pango.Rectangle CharExtents { 
			get {
				Pango.Rectangle logical_rect;
				IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
				pango_layout_iter_get_char_extents(Handle, native_logical_rect);
				logical_rect = Pango.Rectangle.New (native_logical_rect);
				Marshal.FreeHGlobal (native_logical_rect);
				return logical_rect;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_cluster_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetClusterExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_cluster_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_layout_iter_get_index(IntPtr raw);

		public int Index { 
			get {
				int raw_ret = pango_layout_iter_get_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_layout(IntPtr raw);

		public Pango.Layout Layout { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_layout(Handle);
				Pango.Layout ret = GLib.Object.GetObject(raw_ret) as Pango.Layout;
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_layout_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetLayoutExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_layout_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_line(IntPtr raw);

		public Pango.LayoutLine Line { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_line(Handle);
				Pango.LayoutLine ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutLine) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutLine), false);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_line_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetLineExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_line_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_line_readonly(IntPtr raw);

		public Pango.LayoutLine LineReadonly { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_line_readonly(Handle);
				Pango.LayoutLine ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutLine) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutLine), false);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_line_yrange(IntPtr raw, out int y0_, out int y1_);

		public void GetLineYrange(out int y0_, out int y1_) {
			pango_layout_iter_get_line_yrange(Handle, out y0_, out y1_);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_run(IntPtr raw);

		public Pango.LayoutRun Run { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_run(Handle);
				Pango.LayoutRun ret = Pango.LayoutRun.New (raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_get_run_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetRunExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_run_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_run_readonly(IntPtr raw);

		public Pango.LayoutRun RunReadonly { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_run_readonly(Handle);
				Pango.LayoutRun ret = Pango.LayoutRun.New (raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_iter_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_iter_next_char(IntPtr raw);

		public bool NextChar() {
			bool raw_ret = pango_layout_iter_next_char(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_iter_next_cluster(IntPtr raw);

		public bool NextCluster() {
			bool raw_ret = pango_layout_iter_next_cluster(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_iter_next_line(IntPtr raw);

		public bool NextLine() {
			bool raw_ret = pango_layout_iter_next_line(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_iter_next_run(IntPtr raw);

		public bool NextRun() {
			bool raw_ret = pango_layout_iter_next_run(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public LayoutIter(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_iter_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			pango_layout_iter_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return pango_layout_iter_free;
			}
		}

		[Obsolete("Pango.LayoutIter is now freed automatically")]
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
