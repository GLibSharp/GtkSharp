// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void AnnotationForeachFuncNative(IntPtr _object, IntPtr item, IntPtr user_data);

	internal class AnnotationForeachFuncInvoker {

		AnnotationForeachFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AnnotationForeachFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AnnotationForeachFuncInvoker (AnnotationForeachFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AnnotationForeachFuncInvoker (AnnotationForeachFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AnnotationForeachFuncInvoker (AnnotationForeachFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.AnnotationForeachFunc Handler {
			get {
				return new Regress.AnnotationForeachFunc(InvokeNative);
			}
		}

		void InvokeNative (Regress.AnnotationObject _object, string item)
		{
			IntPtr native_item = GLib.Marshaller.StringToPtrGStrdup (item);
			native_cb (_object == null ? IntPtr.Zero : _object.Handle, native_item, __data);
			GLib.Marshaller.Free (native_item);
		}
	}

	internal class AnnotationForeachFuncWrapper {

		public void NativeCallback (IntPtr _object, IntPtr item, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(_object) as Regress.AnnotationObject, GLib.Marshaller.Utf8PtrToString (item));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal AnnotationForeachFuncNative NativeDelegate;
		Regress.AnnotationForeachFunc managed;

		public AnnotationForeachFuncWrapper (Regress.AnnotationForeachFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AnnotationForeachFuncNative (NativeCallback);
		}

		public static Regress.AnnotationForeachFunc GetManagedDelegate (AnnotationForeachFuncNative native)
		{
			if (native == null)
				return null;
			AnnotationForeachFuncWrapper wrapper = (AnnotationForeachFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
