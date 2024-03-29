// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FooSubInterfaceAdapter : GLib.GInterfaceAdapter, Regress.IFooSubInterface {

		[StructLayout (LayoutKind.Sequential)]
		struct RegressFooSubInterfaceIface {
			IntPtr DestroyEvent;
			public DoBarNativeDelegate DoBar;
			public DoBazNativeDelegate DoBaz;
		}

		static RegressFooSubInterfaceIface iface;

		static FooSubInterfaceAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (FooSubInterfaceAdapter));
			iface.DoBar = new DoBarNativeDelegate (DoBar_cb);
			iface.DoBaz = new DoBazNativeDelegate (DoBaz_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DoBarNativeDelegate (IntPtr inst);

		static void DoBar_cb (IntPtr inst)
		{
			try {
				IFooSubInterfaceImplementor __obj = GLib.Object.GetObject (inst, false) as IFooSubInterfaceImplementor;
				__obj.DoBar ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DoBazNativeDelegate (IntPtr inst, IntPtr cb, IntPtr user_data);

		static void DoBaz_cb (IntPtr inst, IntPtr cb, IntPtr user_data)
		{
			try {
				IFooSubInterfaceImplementor __obj = GLib.Object.GetObject (inst, false) as IFooSubInterfaceImplementor;
				__obj.DoBaz (cb);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			RegressFooSubInterfaceIface native_iface = (RegressFooSubInterfaceIface) Marshal.PtrToStructure (ifaceptr, typeof (RegressFooSubInterfaceIface));
			native_iface.DoBar = iface.DoBar;
			native_iface.DoBaz = iface.DoBaz;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public FooSubInterfaceAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public FooSubInterfaceAdapter (IFooSubInterfaceImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public FooSubInterfaceAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_sub_interface_get_type();

		private static GLib.GType _gtype = new GLib.GType (regress_foo_sub_interface_get_type ());

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

		public static IFooSubInterface GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IFooSubInterface GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IFooSubInterfaceImplementor)
				return new FooSubInterfaceAdapter (obj as IFooSubInterfaceImplementor);
			else if (obj as IFooSubInterface == null)
				return new FooSubInterfaceAdapter (obj.Handle);
			else
				return obj as IFooSubInterface;
		}

		public IFooSubInterfaceImplementor Implementor {
			get {
				return implementor as IFooSubInterfaceImplementor;
			}
		}

		[GLib.Signal("destroy-event")]
		public event System.EventHandler DestroyEvent {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("destroy-event", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("destroy-event", value);
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_sub_interface_do_bar(IntPtr raw);

		public void DoBar() {
			regress_foo_sub_interface_do_bar(Handle);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_sub_interface_do_baz(IntPtr raw, IntPtr cb, IntPtr user_data);

		public void DoBaz(IntPtr cb, IntPtr user_data) {
			regress_foo_sub_interface_do_baz(Handle, cb, user_data);
		}

#endregion
	}
}
