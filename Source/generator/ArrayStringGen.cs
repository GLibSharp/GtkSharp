// GtkSharp.Generation.ArrayStringGen.cs - The String Array type Generatable.
//
// Author: Andoni Morales <amorales@fluendo.com>
//
// Copyright (c) 2022 Fluendo S.A. <contact@fluendo.com.com
// Copyright (c) 2022 Andoni Morales <ylatuya@gmail.com>
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
	public class ArrayStringGen : SimpleBase, IManualMarshaler {

		public ArrayStringGen(string ctype, ArrayParameter parameter) : base(ctype, "string[]", "null") {
			Parameter = parameter;
		}

		public override string MarshalType => "IntPtr";

		public ArrayParameter Parameter { get; }

		string CountCast {
			get {
				if (Parameter is ArrayCountPair arrayCountPair) {
					if (arrayCountPair.CountParameter.CSType != "int") {
						return "(int)";
					}
				}
				return "";
			}
		}

		string Count {
			get {
				if (Parameter is ArrayCountPair arrayCountPair) {
					return arrayCountPair.CountParameter.CallName;
				} else if (Parameter.FixedArrayLength.HasValue) {
					return Parameter.FixedArrayLength.Value.ToString();
				}
				return "";
			}
		}

		public override string FromNative(string var) {
			if (Parameter.NullTerminated) {
				return $"GLib.Marshaller.NullTermPtrToStringArray ({var}, false)";
			} else {
				return $"GLib.Marshaller.PtrToStringArray ({var}, {CountCast}{Count}, false)";
			}
		}

		public string AllocNative(string var) {
			var nullTerminated = Parameter.NullTerminated ? "true" : "false";
			return $"GLib.Marshaller.StringArrayToStrvPtr({var}, {nullTerminated})";
		}

		public string ReleaseNative(string var) {
			if (Parameter.NullTerminated) {
				return $"GLib.Marshaller.StrFreeV ({var})";
			} else {
				return $"GLib.Marshaller.StringArrayPtrFree ({var}, {CountCast}{Count})";
			}
		}
	}
}