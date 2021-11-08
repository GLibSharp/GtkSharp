// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class WindowAdapter : GLib.GInterfaceAdapter, Atk.IWindow {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkWindowIface {
		}

		static AtkWindowIface iface;

		static WindowAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (WindowAdapter));
		}

		static void Initialize (IntPtr ptr, IntPtr data)
		{
		}

		GLib.Object implementor;

		public WindowAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public WindowAdapter (IWindowImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public WindowAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("atk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_window_get_type();

		private static GLib.GType _gtype = new GLib.GType (atk_window_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IWindow GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IWindow GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IWindowImplementor)
				return new WindowAdapter (obj as IWindowImplementor);
			else if (obj as IWindow == null)
				return new WindowAdapter (obj.Handle);
			else
				return obj as IWindow;
		}

		public IWindowImplementor Implementor {
			get {
				return implementor as IWindowImplementor;
			}
		}

#endregion
	}
}