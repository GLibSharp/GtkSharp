// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.FileMeasureFlagsGType))]
	public enum FileMeasureFlags : uint {

		None,
		ReportAnyError = 1 << 1,
		ApparentSize = 1 << 2,
		NoXdev = 1 << 3,
	}

	internal class FileMeasureFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_measure_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_file_measure_flags_get_type ());
			}
		}
	}
#endregion
}
