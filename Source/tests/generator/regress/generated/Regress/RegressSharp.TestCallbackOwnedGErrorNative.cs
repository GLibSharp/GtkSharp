// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void TestCallbackOwnedGErrorNative(IntPtr error);

	internal class TestCallbackOwnedGErrorInvoker {

		TestCallbackOwnedGErrorNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TestCallbackOwnedGErrorInvoker() {
			if (__notify == null)
				return;
			__notify(__data);
		}

		internal TestCallbackOwnedGErrorInvoker(TestCallbackOwnedGErrorNative native_cb) : this(native_cb, IntPtr.Zero, null) { }

		internal TestCallbackOwnedGErrorInvoker(TestCallbackOwnedGErrorNative native_cb, IntPtr data) : this(native_cb, data, null) { }

		internal TestCallbackOwnedGErrorInvoker(TestCallbackOwnedGErrorNative native_cb, IntPtr data, GLib.DestroyNotify notify) {
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.TestCallbackOwnedGError Handler {
			get {
				return new Regress.TestCallbackOwnedGError(InvokeNative);
			}
		}

		void InvokeNative(IntPtr error) {
			native_cb(error);
		}
	}

	internal class TestCallbackOwnedGErrorWrapper {

		public void NativeCallback(IntPtr error) {
			try {
				managed(error);
				if (release_on_call)
					gch.Free();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException(e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled() {
			release_on_call = true;
			gch = GCHandle.Alloc(this);
		}

		internal TestCallbackOwnedGErrorNative NativeDelegate;
		Regress.TestCallbackOwnedGError managed;

		public TestCallbackOwnedGErrorWrapper(Regress.TestCallbackOwnedGError managed) {
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TestCallbackOwnedGErrorNative(NativeCallback);
		}

		public static Regress.TestCallbackOwnedGError GetManagedDelegate(TestCallbackOwnedGErrorNative native) {
			if (native == null)
				return null;
			TestCallbackOwnedGErrorWrapper wrapper = (TestCallbackOwnedGErrorWrapper)native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
	#endregion
}