// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

#region Autogenerated code
	public partial interface IFooSubInterface : GLib.IWrapper {

		event System.EventHandler DestroyEvent;
		void DoBar();
		void DoBaz(IntPtr cb, IntPtr user_data);
	}

	[GLib.GInterface (typeof (FooSubInterfaceAdapter))]
	public partial interface IFooSubInterfaceImplementor : GLib.IWrapper {

		void DoBar ();
		void DoBaz (IntPtr cb);
	}
#endregion
}
