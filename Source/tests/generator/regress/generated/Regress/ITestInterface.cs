// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

#region Autogenerated code
	public partial interface ITestInterface : GLib.IWrapper {

		event Regress.InterfaceSignalHandler InterfaceSignal;
		void EmitSignal();
		int Number {
			get; set;
		}
	}

	[GLib.GInterface (typeof (TestInterfaceAdapter))]
	public partial interface ITestInterfaceImplementor : GLib.IWrapper {

		[GLib.Property ("number")]
		int Number {
			get; set;
		}
	}
#endregion
}
