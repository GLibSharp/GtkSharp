// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Rc {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_rc_add_default_file(IntPtr filename);

		[Obsolete]
		public static void AddDefaultFile(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			gtk_rc_add_default_file(native_filename);
			GLib.Marshaller.Free (native_filename);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_find_module_in_path(IntPtr module_file);

		[Obsolete]
		public static string FindModuleInPath(string module_file) {
			IntPtr native_module_file = GLib.Marshaller.StringToPtrGStrdup (module_file);
			IntPtr raw_ret = gtk_rc_find_module_in_path(native_module_file);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_module_file);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_default_files();

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_rc_set_default_files(IntPtr filenames);

		[Obsolete]
		public static string[] DefaultFiles { 
			get {
				IntPtr raw_ret = gtk_rc_get_default_files();
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringArrayToStrvPtr(value, true);
				gtk_rc_set_default_files(native_value);
				GLib.Marshaller.StrFreeV (native_value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_im_module_file();

		[Obsolete]
		public static string ImModuleFile { 
			get {
				IntPtr raw_ret = gtk_rc_get_im_module_file();
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_im_module_path();

		[Obsolete]
		public static string ImModulePath { 
			get {
				IntPtr raw_ret = gtk_rc_get_im_module_path();
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_module_dir();

		[Obsolete]
		public static string ModuleDir { 
			get {
				IntPtr raw_ret = gtk_rc_get_module_dir();
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_style(IntPtr widget);

		[Obsolete]
		public static Gtk.Style GetStyle(Gtk.Widget widget) {
			IntPtr raw_ret = gtk_rc_get_style(widget == null ? IntPtr.Zero : widget.Handle);
			Gtk.Style ret = GLib.Object.GetObject(raw_ret) as Gtk.Style;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_get_theme_dir();

		[Obsolete]
		public static string ThemeDir { 
			get {
				IntPtr raw_ret = gtk_rc_get_theme_dir();
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_rc_parse(IntPtr filename);

		[Obsolete]
		public static void Parse(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			gtk_rc_parse(native_filename);
			GLib.Marshaller.Free (native_filename);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_rc_parse_string(IntPtr rc_string);

		[Obsolete]
		public static void ParseString(string rc_string) {
			IntPtr native_rc_string = GLib.Marshaller.StringToPtrGStrdup (rc_string);
			gtk_rc_parse_string(native_rc_string);
			GLib.Marshaller.Free (native_rc_string);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_rc_reparse_all();

		[Obsolete]
		public static bool ReparseAll() {
			bool raw_ret = gtk_rc_reparse_all();
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
