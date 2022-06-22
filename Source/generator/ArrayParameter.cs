// GtkSharp.Generation.Parameters.cs - The Parameters Generation Class.
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// Copyright (c) 2001-2003 Mike Kestner
// Copyright (c) 2004 Novell, Inc.
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
	using System.Collections.Generic;
	using System.Xml;

	public class ArrayParameter : Parameter {

		bool null_terminated;

		public ArrayParameter (XmlElement elem) : base (elem)
		{
			null_terminated = elem.GetAttributeAsBoolean ("null_term_array");
			if (elem.HasAttribute ("array_len"))
				FixedArrayLength = Int32.Parse (elem.GetAttribute ("array_len"));
		}

		public override string MarshalType {
			get {
				if (Generatable is StructBase)
					return CSType;
				else
					return base.MarshalType;
			}
		}

		bool NullTerminated {
			get {
				return null_terminated;
			}
		}

		public int? FixedArrayLength { get; private set; }

		public override string[] Prepare {
			get {
				if (CSType == MarshalType && !FixedArrayLength.HasValue)
					return new string [0];

				var result = new List<string> ();

				if (FixedArrayLength.HasValue) {
					result.Add (String.Format ("{0} = new {1}[{2}];", Name, MarshalType.TrimEnd ('[', ']'), FixedArrayLength));
					return result.ToArray ();
				}
				result.Add (String.Format ("int cnt_{0} = {0} == null ? 0 : {0}.Length;", CallName));
				result.Add (String.Format ("{0}[] native_{1} = new {0} [cnt_{1}" + (NullTerminated ? " + 1" : "") + "];", MarshalType.TrimEnd('[', ']'), CallName));
				result.Add (String.Format ("for (int i = 0; i < cnt_{0}; i++)", CallName));
				IGeneratable gen = Generatable;
				if (gen is IManualMarshaler)
					result.Add (String.Format ("\tnative_{0} [i] = {1};", CallName, (gen as IManualMarshaler).AllocNative (CallName + "[i]")));
				else
					result.Add (String.Format ("\tnative_{0} [i] = {1};", CallName, gen.CallByName (CallName + "[i]")));

				if (NullTerminated)
					result.Add (String.Format ("native_{0} [cnt_{0}] = IntPtr.Zero;", CallName));
				return result.ToArray ();
			}
		}

		public override string CallString {
			get {
				string callString;

				if (FixedArrayLength.HasValue)
					return base.CallString;

				if (CSType != MarshalType)
				{
					callString = "native_" + CallName;
				} else
                {
					callString = CallName;
				}

				if (!string.IsNullOrEmpty(PassAs)) {
					callString = $"{PassAs} {callString}";
				}

				return callString;
			}
		}

		public override string[] Finish {
			get {
				if (CSType == MarshalType)
					return new string [0];

				IGeneratable gen = Generatable;
				if (gen is IManualMarshaler) {
					string [] result = new string [4];
					result [0] = "for (int i = 0; i < native_" + CallName + ".Length" + (NullTerminated ? " - 1" : "") + "; i++) {";
					result [1] = "\t" + CallName + " [i] = " + Generatable.FromNative ("native_" + CallName + "[i]") + ";";
					result [2] = "\t" + (gen as IManualMarshaler).ReleaseNative ("native_" + CallName + "[i]") + ";";
					result [3] = "}";
					return result;
				}

				return new string [0];
			}
		}
	}

	public class ArrayCountPair : ArrayParameter {

		Parameter count_param;
		bool invert;

		public ArrayCountPair (XmlElement array_elem, XmlElement count_elem, bool invert) : base (array_elem)
		{
			count_param = new Parameter(count_elem);
			this.invert = invert;
		}

		string CountCast {
			get {
				if (count_param.CSType == "int")
					return string.Empty;
				else
					return $"({count_param.CSType})";
			}
		}

        public override string[] Prepare
        {
			get
            {
				if (CSType == MarshalType && !FixedArrayLength.HasValue)
                {
					return new string[] { $"{count_param.CSType} cnt_{CallName} = {CountCast}({CallName} == null ? 0 : {CallName}.Length);" };
				}
				else
                {
					return base.Prepare;
                }
			}
        }

        public override string CallString {
			get {
				string pass_ass = string.IsNullOrEmpty(count_param.PassAs) ? "" : $"{count_param.PassAs} ";
				if (invert)
					return $"{pass_ass}cnt_{CallName},  {base.CallString}";
				else
					return $"{base.CallString}, {pass_ass}cnt_{CallName}";
			}
		}

		public override string NativeSignature {
			get {
				if (invert)
					return $"{count_param.NativeSignature}, {base.NativeSignature}";
				else
					return $"{base.NativeSignature}, {count_param.NativeSignature}";
			}
		}
	}
}
