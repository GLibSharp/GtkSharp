// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Global {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_bidi_type_for_unichar(uint ch);

		public static Pango.BidiType BidiTypeForUnichar(char ch) {
			int raw_ret = pango_bidi_type_for_unichar(GLib.Marshaller.CharToGUnichar (ch));
			Pango.BidiType ret = (Pango.BidiType) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_extents_to_pixels(IntPtr inclusive, IntPtr nearest);

		public static void ExtentsToPixels(ref Pango.Rectangle inclusive, ref Pango.Rectangle nearest) {
			IntPtr native_inclusive = GLib.Marshaller.StructureToPtrAlloc (inclusive);
			IntPtr native_nearest = GLib.Marshaller.StructureToPtrAlloc (nearest);
			pango_extents_to_pixels(native_inclusive, native_nearest);
			inclusive = Pango.Rectangle.New (native_inclusive);
			Marshal.FreeHGlobal (native_inclusive);
			nearest = Pango.Rectangle.New (native_nearest);
			Marshal.FreeHGlobal (native_nearest);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_find_base_dir(IntPtr text, int length);

		public static Pango.Direction FindBaseDir(string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			int raw_ret = pango_find_base_dir(native_text, System.Text.Encoding.UTF8.GetByteCount (text));
			Pango.Direction ret = (Pango.Direction) raw_ret;
			GLib.Marshaller.Free (native_text);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_find_paragraph_boundary(IntPtr text, int length, out int paragraph_delimiter_index, out int next_paragraph_start);

		public static void FindParagraphBoundary(string text, out int paragraph_delimiter_index, out int next_paragraph_start) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			pango_find_paragraph_boundary(native_text, System.Text.Encoding.UTF8.GetByteCount (text), out paragraph_delimiter_index, out next_paragraph_start);
			GLib.Marshaller.Free (native_text);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_get_log_attrs(IntPtr text, int length, int level, IntPtr language, IntPtr log_attrs, int attrs_len);

		public static void GetLogAttrs(string text, int level, Pango.Language language, Pango.LogAttr log_attrs, int attrs_len) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr native_log_attrs = GLib.Marshaller.StructureToPtrAlloc (log_attrs);
			pango_get_log_attrs(native_text, System.Text.Encoding.UTF8.GetByteCount (text), level, language == null ? IntPtr.Zero : language.Handle, native_log_attrs, attrs_len);
			GLib.Marshaller.Free (native_text);
			Marshal.FreeHGlobal (native_log_attrs);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_gravity_get_for_matrix(IntPtr matrix);

		public static Pango.Gravity GravityGetForMatrix(Pango.Matrix matrix) {
			IntPtr native_matrix = GLib.Marshaller.StructureToPtrAlloc (matrix);
			int raw_ret = pango_gravity_get_for_matrix(native_matrix);
			Pango.Gravity ret = (Pango.Gravity) raw_ret;
			Marshal.FreeHGlobal (native_matrix);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_gravity_get_for_script(int script, int base_gravity, int hint);

		public static Pango.Gravity GravityGetForScript(Pango.Script script, Pango.Gravity base_gravity, Pango.GravityHint hint) {
			int raw_ret = pango_gravity_get_for_script((int) script, (int) base_gravity, (int) hint);
			Pango.Gravity ret = (Pango.Gravity) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_gravity_get_for_script_and_width(int script, bool wide, int base_gravity, int hint);

		public static Pango.Gravity GravityGetForScriptAndWidth(Pango.Script script, bool wide, Pango.Gravity base_gravity, Pango.GravityHint hint) {
			int raw_ret = pango_gravity_get_for_script_and_width((int) script, wide, (int) base_gravity, (int) hint);
			Pango.Gravity ret = (Pango.Gravity) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double pango_gravity_to_rotation(int gravity);

		public static double GravityToRotation(Pango.Gravity gravity) {
			double raw_ret = pango_gravity_to_rotation((int) gravity);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_is_zero_width(uint ch);

		public static bool IsZeroWidth(char ch) {
			bool raw_ret = pango_is_zero_width(GLib.Marshaller.CharToGUnichar (ch));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_itemize_with_base_dir(IntPtr context, int base_dir, IntPtr text, int start_index, int length, IntPtr attrs, IntPtr cached_iter);

		public static GLib.List ItemizeWithBaseDir(Pango.Context context, Pango.Direction base_dir, string text, int start_index, int length, Pango.AttrList attrs, Pango.AttrIterator cached_iter) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr raw_ret = pango_itemize_with_base_dir(context == null ? IntPtr.Zero : context.Handle, (int) base_dir, native_text, start_index, length, attrs == null ? IntPtr.Zero : attrs.Handle, cached_iter == null ? IntPtr.Zero : cached_iter.Handle);
			GLib.List ret = new GLib.List(raw_ret);
			GLib.Marshaller.Free (native_text);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_parse_enum(IntPtr type, IntPtr str, out int value, bool warn, IntPtr possible_values);

		[Obsolete]
		public static bool ParseEnum(GLib.GType type, string str, out int value, bool warn, string possible_values) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			bool raw_ret = pango_parse_enum(type.Val, native_str, out value, warn, GLib.Marshaller.StringToPtrGStrdup(possible_values));
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_parse_stretch(IntPtr str, out int stretch, bool warn);

		public static bool ParseStretch(string str, out Pango.Stretch stretch, bool warn) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			int native_stretch;
			bool raw_ret = pango_parse_stretch(native_str, out native_stretch, warn);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			stretch = (Pango.Stretch) native_stretch;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_parse_style(IntPtr str, out int style, bool warn);

		public static bool ParseStyle(string str, out Pango.Style style, bool warn) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			int native_style;
			bool raw_ret = pango_parse_style(native_str, out native_style, warn);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			style = (Pango.Style) native_style;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_parse_variant(IntPtr str, out int variant, bool warn);

		public static bool ParseVariant(string str, out Pango.Variant variant, bool warn) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			int native_variant;
			bool raw_ret = pango_parse_variant(native_str, out native_variant, warn);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			variant = (Pango.Variant) native_variant;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_parse_weight(IntPtr str, out int weight, bool warn);

		public static bool ParseWeight(string str, out Pango.Weight weight, bool warn) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			int native_weight;
			bool raw_ret = pango_parse_weight(native_str, out native_weight, warn);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			weight = (Pango.Weight) native_weight;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_quantize_line_geometry(out int thickness, out int position);

		public static void QuantizeLineGeometry(out int thickness, out int position) {
			pango_quantize_line_geometry(out thickness, out position);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_scan_int(ref IntPtr pos, out int out_param);

		[Obsolete]
		public static bool ScanInt(ref string pos, out int out_param) {
			IntPtr native_pos = GLib.Marshaller.StringToPtrGStrdup (pos);
			bool raw_ret = pango_scan_int(ref native_pos, out out_param);
			bool ret = raw_ret;
			pos = GLib.Marshaller.Utf8PtrToString (native_pos);
			GLib.Marshaller.Free (native_pos);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_script_for_unichar(uint ch);

		public static Pango.Script ScriptForUnichar(char ch) {
			int raw_ret = pango_script_for_unichar(GLib.Marshaller.CharToGUnichar (ch));
			Pango.Script ret = (Pango.Script) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_script_get_sample_language(int script);

		public static Pango.Language ScriptGetSampleLanguage(Pango.Script script) {
			IntPtr raw_ret = pango_script_get_sample_language((int) script);
			Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_shape_full(IntPtr item_text, int item_length, IntPtr paragraph_text, int paragraph_length, IntPtr analysis, IntPtr glyphs);

		public static void ShapeFull(string item_text, string paragraph_text, Pango.Analysis analysis, Pango.GlyphString glyphs) {
			IntPtr native_item_text = GLib.Marshaller.StringToPtrGStrdup (item_text);
			IntPtr native_paragraph_text = GLib.Marshaller.StringToPtrGStrdup (paragraph_text);
			IntPtr native_analysis = GLib.Marshaller.StructureToPtrAlloc (analysis);
			pango_shape_full(native_item_text, System.Text.Encoding.UTF8.GetByteCount (item_text), native_paragraph_text, System.Text.Encoding.UTF8.GetByteCount (paragraph_text), native_analysis, glyphs == null ? IntPtr.Zero : glyphs.Handle);
			GLib.Marshaller.Free (native_item_text);
			GLib.Marshaller.Free (native_paragraph_text);
			Marshal.FreeHGlobal (native_analysis);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_skip_space(ref IntPtr pos);

		[Obsolete]
		public static bool SkipSpace(ref string pos) {
			IntPtr native_pos = GLib.Marshaller.StringToPtrGStrdup (pos);
			bool raw_ret = pango_skip_space(ref native_pos);
			bool ret = raw_ret;
			pos = GLib.Marshaller.Utf8PtrToString (native_pos);
			GLib.Marshaller.Free (native_pos);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_split_file_list(IntPtr str);

		[Obsolete]
		public static string SplitFileList(string str) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			IntPtr raw_ret = pango_split_file_list(native_str);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_str);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_trim_string(IntPtr str);

		[Obsolete]
		public static string TrimString(string str) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			IntPtr raw_ret = pango_trim_string(native_str);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_str);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_unichar_direction(uint ch);

		public static Pango.Direction UnicharDirection(char ch) {
			int raw_ret = pango_unichar_direction(GLib.Marshaller.CharToGUnichar (ch));
			Pango.Direction ret = (Pango.Direction) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_version_check(int required_major, int required_minor, int required_micro);

		public static string VersionCheck(int required_major, int required_minor, int required_micro) {
			IntPtr raw_ret = pango_version_check(required_major, required_minor, required_micro);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_version_string();

		public static string VersionString() {
			IntPtr raw_ret = pango_version_string();
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

#endregion
	}
}
