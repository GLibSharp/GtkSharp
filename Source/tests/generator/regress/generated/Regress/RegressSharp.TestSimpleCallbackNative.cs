// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void TestSimpleCallbackNative();

	internal class TestSimpleCallbackInvoker {

		TestSimpleCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TestSimpleCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TestSimpleCallbackInvoker (TestSimpleCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TestSimpleCallbackInvoker (TestSimpleCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TestSimpleCallbackInvoker (TestSimpleCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.TestSimpleCallback Handler {
			get {
				return new Regress.TestSimpleCallback(InvokeNative);
			}
		}

		void InvokeNative ()
		{
			native_cb ();
		}
	}

	internal class TestSimpleCallbackWrapper {

		public void NativeCallback ()
		{
			try {
				managed ();
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

		internal TestSimpleCallbackNative NativeDelegate;
		Regress.TestSimpleCallback managed;

		public TestSimpleCallbackWrapper (Regress.TestSimpleCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TestSimpleCallbackNative (NativeCallback);
		}

		public static Regress.TestSimpleCallback GetManagedDelegate (TestSimpleCallbackNative native)
		{
			if (native == null)
				return null;
			TestSimpleCallbackWrapper wrapper = (TestSimpleCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
