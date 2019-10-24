// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CairoHelper {

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cairo_create(IntPtr window);

		[Obsolete]
		public static Cairo.Context Create(Gdk.Window window) {
			IntPtr raw_ret = gdk_cairo_create(window == null ? IntPtr.Zero : window.Handle);
			Cairo.Context ret = new Cairo.Context (raw_ret, true);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_draw_from_gl(IntPtr cr, IntPtr window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);

		public static void DrawFromGl(Cairo.Context cr, Gdk.Window window, int source, int source_type, int buffer_scale, int x, int y, int width, int height) {
			gdk_cairo_draw_from_gl(cr == null ? IntPtr.Zero : cr.Handle, window == null ? IntPtr.Zero : window.Handle, source, source_type, buffer_scale, x, y, width, height);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_cairo_get_clip_rectangle(IntPtr cr, IntPtr rect);

		public static bool GetClipRectangle(Cairo.Context cr, Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			bool raw_ret = gdk_cairo_get_clip_rectangle(cr == null ? IntPtr.Zero : cr.Handle, native_rect);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rect);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cairo_get_drawing_context(IntPtr cr);

		public static Gdk.DrawingContext GetDrawingContext(Cairo.Context cr) {
			IntPtr raw_ret = gdk_cairo_get_drawing_context(cr == null ? IntPtr.Zero : cr.Handle);
			Gdk.DrawingContext ret = GLib.Object.GetObject(raw_ret) as Gdk.DrawingContext;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_rectangle(IntPtr cr, IntPtr rectangle);

		public static void Rectangle(Cairo.Context cr, Gdk.Rectangle rectangle) {
			IntPtr native_rectangle = GLib.Marshaller.StructureToPtrAlloc (rectangle);
			gdk_cairo_rectangle(cr == null ? IntPtr.Zero : cr.Handle, native_rectangle);
			Marshal.FreeHGlobal (native_rectangle);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_region(IntPtr cr, IntPtr region);

		public static void Region(Cairo.Context cr, Cairo.Region region) {
			gdk_cairo_region(cr == null ? IntPtr.Zero : cr.Handle, region == null ? IntPtr.Zero : region.Handle);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cairo_region_create_from_surface(IntPtr surface);

		public static Cairo.Region RegionCreateFromSurface(Cairo.Surface surface) {
			IntPtr raw_ret = gdk_cairo_region_create_from_surface(surface.Handle);
			Cairo.Region ret = new Cairo.Region(raw_ret);
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_set_source_color(IntPtr cr, IntPtr color);

		[Obsolete]
		public static void SetSourceColor(Cairo.Context cr, Gdk.Color color) {
			IntPtr native_color = GLib.Marshaller.StructureToPtrAlloc (color);
			gdk_cairo_set_source_color(cr == null ? IntPtr.Zero : cr.Handle, native_color);
			Marshal.FreeHGlobal (native_color);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_set_source_pixbuf(IntPtr cr, IntPtr pixbuf, double pixbuf_x, double pixbuf_y);

		public static void SetSourcePixbuf(Cairo.Context cr, Gdk.Pixbuf pixbuf, double pixbuf_x, double pixbuf_y) {
			gdk_cairo_set_source_pixbuf(cr == null ? IntPtr.Zero : cr.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle, pixbuf_x, pixbuf_y);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_set_source_rgba(IntPtr cr, IntPtr rgba);

		public static void SetSourceRgba(Cairo.Context cr, Gdk.RGBA rgba) {
			IntPtr native_rgba = GLib.Marshaller.StructureToPtrAlloc (rgba);
			gdk_cairo_set_source_rgba(cr == null ? IntPtr.Zero : cr.Handle, native_rgba);
			Marshal.FreeHGlobal (native_rgba);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cairo_set_source_window(IntPtr cr, IntPtr window, double x, double y);

		public static void SetSourceWindow(Cairo.Context cr, Gdk.Window window, double x, double y) {
			gdk_cairo_set_source_window(cr == null ? IntPtr.Zero : cr.Handle, window == null ? IntPtr.Zero : window.Handle, x, y);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cairo_surface_create_from_pixbuf(IntPtr pixbuf, int scale, IntPtr for_window);

		public static Cairo.Surface SurfaceCreateFromPixbuf(Gdk.Pixbuf pixbuf, int scale, Gdk.Window for_window) {
			IntPtr raw_ret = gdk_cairo_surface_create_from_pixbuf(pixbuf == null ? IntPtr.Zero : pixbuf.Handle, scale, for_window == null ? IntPtr.Zero : for_window.Handle);
			Cairo.Surface ret = Cairo.Surface.Lookup (raw_ret, true);
			return ret;
		}

#endregion
	}
}
