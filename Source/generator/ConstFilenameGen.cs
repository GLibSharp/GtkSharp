// ConstFilenameGen.cs - The Const Filename type Generatable.
//
// Author:  Mike Kestner <mkestner@novell.com>
//
// Copyright (c) 2005 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the GNU General Public
// License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GtkSharp.Generation {

	using System;

	public class ConstFilenameGen : SimpleBase, IManualMarshaler {

		public ConstFilenameGen(string ctype) : base(ctype, "string", "null") { }

		public override string MarshalType {
			get {
				return "IntPtr";
			}
		}

		public override string FromNative(string var) {
			return "GLib.Marshaller.FilenamePtrToString (" + var + ")";
		}

		public string AllocNative(string managed_var) {
			return "GLib.Marshaller.StringToFilenamePtr (" + managed_var + ")";
		}

		public string ReleaseNative(string native_var) {
			return "GLib.Marshaller.Free (" + native_var + ")";
		}
	}
}