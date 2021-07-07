// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextAttributes : GLib.Opaque {

		public Gtk.Justification Justification {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("justification"));
					return (Gtk.Justification) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("justification"));
					*raw_ptr = (int) value;
				}
			}
		}

		public Gtk.TextDirection Direction {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("direction"));
					return (Gtk.TextDirection) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("direction"));
					*raw_ptr = (int) value;
				}
			}
		}

		public Pango.FontDescription Font {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("font"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Pango.FontDescription), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("font"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public double FontScale {
			get {
				unsafe {
					double* raw_ptr = (double*)(((byte*)Handle) + abi_info.GetFieldOffset("font_scale"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					double* raw_ptr = (double*)(((byte*)Handle) + abi_info.GetFieldOffset("font_scale"));
					*raw_ptr = value;
				}
			}
		}

		public int LeftMargin {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("left_margin"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("left_margin"));
					*raw_ptr = value;
				}
			}
		}

		public int RightMargin {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("right_margin"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("right_margin"));
					*raw_ptr = value;
				}
			}
		}

		public int Indent {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("indent"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("indent"));
					*raw_ptr = value;
				}
			}
		}

		public int PixelsAboveLines {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_above_lines"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_above_lines"));
					*raw_ptr = value;
				}
			}
		}

		public int PixelsBelowLines {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_below_lines"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_below_lines"));
					*raw_ptr = value;
				}
			}
		}

		public int PixelsInsideWrap {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_inside_wrap"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("pixels_inside_wrap"));
					*raw_ptr = value;
				}
			}
		}

		public Pango.TabArray Tabs {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("tabs"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Pango.TabArray) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Pango.TabArray), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("tabs"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public Gtk.WrapMode WrapMode {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("wrap_mode"));
					return (Gtk.WrapMode) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("wrap_mode"));
					*raw_ptr = (int) value;
				}
			}
		}

		public Pango.Language Language {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("language"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Pango.Language), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("language"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public bool Invisible {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("invisible"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("invisible"));
					*raw_ptr = value;
				}
			}
		}

		public bool BgFullHeight {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("bg_full_height"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("bg_full_height"));
					*raw_ptr = value;
				}
			}
		}

		public bool Editable {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("editable"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("editable"));
					*raw_ptr = value;
				}
			}
		}

		public bool NoFallback {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("no_fallback"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("no_fallback"));
					*raw_ptr = value;
				}
			}
		}

		public int LetterSpacing {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("letter_spacing"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("letter_spacing"));
					*raw_ptr = value;
				}
			}
		}

		public string FontFeatures {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("font_features"));
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("font_features"));
					*raw_ptr = GLib.Marshaller.StringToPtrGStrdup (value);
				}
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_attributes_copy(IntPtr raw);

		public Gtk.TextAttributes Copy() {
			IntPtr raw_ret = gtk_text_attributes_copy(Handle);
			Gtk.TextAttributes ret = raw_ret == IntPtr.Zero ? null : (Gtk.TextAttributes) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TextAttributes), true);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_text_attributes_copy_values(IntPtr raw, IntPtr dest);

		public void CopyValues(Gtk.TextAttributes dest) {
			gtk_text_attributes_copy_values(Handle, dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_attributes_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_text_attributes_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public TextAttributes(IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_attributes_new();

		public TextAttributes () 
		{
			Raw = gtk_text_attributes_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_attributes_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_text_attributes_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_text_attributes_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_text_attributes_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_text_attributes_unref (handle);
				return false;
			}
		}

		~TextAttributes ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			if (ForceFinalizeInMainThread) {
				GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
			} else {
				info.Handler();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("refcount"
							, 0
							, (uint) Marshal.SizeOf(typeof(uint)) // refcount
							, null
							, "appearance"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_refcountAlign), "refcount")
							, 0
							),
						new GLib.AbiField("appearance"
							, -1
							, Gtk.TextAppearance.abi_info.Size // appearance
							, "refcount"
							, "justification"
							, Gtk.TextAppearance.abi_info.Align
							, 0
							),
						new GLib.AbiField("justification"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gtk.Justification))) // justification
							, "appearance"
							, "direction"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_justificationAlign), "justification")
							, 0
							),
						new GLib.AbiField("direction"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gtk.TextDirection))) // direction
							, "justification"
							, "font"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_directionAlign), "direction")
							, 0
							),
						new GLib.AbiField("font"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // font
							, "direction"
							, "font_scale"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("font_scale"
							, -1
							, (uint) Marshal.SizeOf(typeof(double)) // font_scale
							, "font"
							, "left_margin"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_font_scaleAlign), "font_scale")
							, 0
							),
						new GLib.AbiField("left_margin"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // left_margin
							, "font_scale"
							, "right_margin"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_left_marginAlign), "left_margin")
							, 0
							),
						new GLib.AbiField("right_margin"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // right_margin
							, "left_margin"
							, "indent"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_right_marginAlign), "right_margin")
							, 0
							),
						new GLib.AbiField("indent"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // indent
							, "right_margin"
							, "pixels_above_lines"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_indentAlign), "indent")
							, 0
							),
						new GLib.AbiField("pixels_above_lines"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // pixels_above_lines
							, "indent"
							, "pixels_below_lines"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_pixels_above_linesAlign), "pixels_above_lines")
							, 0
							),
						new GLib.AbiField("pixels_below_lines"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // pixels_below_lines
							, "pixels_above_lines"
							, "pixels_inside_wrap"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_pixels_below_linesAlign), "pixels_below_lines")
							, 0
							),
						new GLib.AbiField("pixels_inside_wrap"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // pixels_inside_wrap
							, "pixels_below_lines"
							, "tabs"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_pixels_inside_wrapAlign), "pixels_inside_wrap")
							, 0
							),
						new GLib.AbiField("tabs"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // tabs
							, "pixels_inside_wrap"
							, "wrap_mode"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("wrap_mode"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gtk.WrapMode))) // wrap_mode
							, "tabs"
							, "language"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_wrap_modeAlign), "wrap_mode")
							, 0
							),
						new GLib.AbiField("language"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // language
							, "wrap_mode"
							, "pg_bg_color"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pg_bg_color"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pg_bg_color
							, "language"
							, "invisible"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("invisible"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // invisible
							, "pg_bg_color"
							, "bg_full_height"
							, 1
							, 1
							),
						new GLib.AbiField("bg_full_height"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // bg_full_height
							, "invisible"
							, "editable"
							, 1
							, 1
							),
						new GLib.AbiField("editable"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // editable
							, "bg_full_height"
							, "no_fallback"
							, 1
							, 1
							),
						new GLib.AbiField("no_fallback"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // no_fallback
							, "editable"
							, "pg_bg_rgba"
							, 1
							, 1
							),
						new GLib.AbiField("pg_bg_rgba"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pg_bg_rgba
							, "no_fallback"
							, "letter_spacing"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("letter_spacing"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // letter_spacing
							, "pg_bg_rgba"
							, "font_features"
							, (long) Marshal.OffsetOf(typeof(GtkTextAttributes_letter_spacingAlign), "letter_spacing")
							, 0
							),
						new GLib.AbiField("font_features"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // font_features
							, "letter_spacing"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_refcountAlign
		{
			sbyte f1;
			private uint refcount;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_justificationAlign
		{
			sbyte f1;
			private Gtk.Justification justification;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_directionAlign
		{
			sbyte f1;
			private Gtk.TextDirection direction;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_font_scaleAlign
		{
			sbyte f1;
			private double font_scale;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_left_marginAlign
		{
			sbyte f1;
			private int left_margin;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_right_marginAlign
		{
			sbyte f1;
			private int right_margin;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_indentAlign
		{
			sbyte f1;
			private int indent;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_pixels_above_linesAlign
		{
			sbyte f1;
			private int pixels_above_lines;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_pixels_below_linesAlign
		{
			sbyte f1;
			private int pixels_below_lines;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_pixels_inside_wrapAlign
		{
			sbyte f1;
			private int pixels_inside_wrap;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_wrap_modeAlign
		{
			sbyte f1;
			private Gtk.WrapMode wrap_mode;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAttributes_letter_spacingAlign
		{
			sbyte f1;
			private int letter_spacing;
		}


		// End of the ABI representation.

#endregion
	}
}
