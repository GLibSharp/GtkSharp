// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Fontset : GLib.Object {

		public Fontset (IntPtr raw) : base(raw) {}

		protected Fontset() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_fontset_foreach(IntPtr raw, PangoSharp.FontsetForeachFuncNative func, IntPtr data);

		public void Foreach(Pango.FontsetForeachFunc func) {
			PangoSharp.FontsetForeachFuncWrapper func_wrapper = new PangoSharp.FontsetForeachFuncWrapper (func);
			pango_fontset_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_fontset_get_font(IntPtr raw, uint wc);

		public Pango.Font GetFont(uint wc) {
			IntPtr raw_ret = pango_fontset_get_font(Handle, wc);
			Pango.Font ret = GLib.Object.GetObject(raw_ret) as Pango.Font;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_fontset_get_metrics(IntPtr raw);

		public Pango.FontMetrics Metrics { 
			get {
				IntPtr raw_ret = pango_fontset_get_metrics(Handle);
				Pango.FontMetrics ret = raw_ret == IntPtr.Zero ? null : (Pango.FontMetrics) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontMetrics), false);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_fontset_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_fontset_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
