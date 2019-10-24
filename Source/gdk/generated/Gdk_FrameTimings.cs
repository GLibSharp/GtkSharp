// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FrameTimings : GLib.Opaque {

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_frame_timings_get_complete(IntPtr raw);

		public bool Complete { 
			get {
				bool raw_ret = gdk_frame_timings_get_complete(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gdk_frame_timings_get_frame_counter(IntPtr raw);

		public long FrameCounter { 
			get {
				long raw_ret = gdk_frame_timings_get_frame_counter(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gdk_frame_timings_get_frame_time(IntPtr raw);

		public long FrameTime { 
			get {
				long raw_ret = gdk_frame_timings_get_frame_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gdk_frame_timings_get_predicted_presentation_time(IntPtr raw);

		public long PredictedPresentationTime { 
			get {
				long raw_ret = gdk_frame_timings_get_predicted_presentation_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gdk_frame_timings_get_presentation_time(IntPtr raw);

		public long PresentationTime { 
			get {
				long raw_ret = gdk_frame_timings_get_presentation_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gdk_frame_timings_get_refresh_interval(IntPtr raw);

		public long RefreshInterval { 
			get {
				long raw_ret = gdk_frame_timings_get_refresh_interval(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_frame_timings_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_frame_timings_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public FrameTimings(IntPtr raw) : base(raw) {}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_frame_timings_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gdk_frame_timings_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_frame_timings_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gdk_frame_timings_unref (raw);
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
				gdk_frame_timings_unref (handle);
				return false;
			}
		}

		~FrameTimings ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


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
