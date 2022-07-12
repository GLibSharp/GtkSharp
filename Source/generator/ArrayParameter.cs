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

		public ArrayParameter(XmlElement elem) : base(elem) {
			null_terminated = elem.GetAttributeAsBoolean("null_term_array");
			if (elem.HasAttribute("array_len"))
				FixedArrayLength = Int32.Parse(elem.GetAttribute("array_len"));
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

		public override string NativeSignature {
			get {
				if (FixedArrayLength > 0) {
					return $"[MarshalAs(UnmanagedType.LPArray, SizeConst={FixedArrayLength})]{base.NativeSignature}";
				} else {
					return base.NativeSignature;
				}
			}
		}

		public override string[] Prepare {
			get {
				var result = new List<string>();


				if (CSType != MarshalType) {
					var marshalType = MarshalType.TrimEnd('[', ']');
					if (PassAs != "out") {
						if (FixedArrayLength.HasValue) {
							result.Add(String.Format($"int cnt_{CallName} = {FixedArrayLength};"));
						} else {
							result.Add(String.Format($"int cnt_{CallName} = {CallName} == null ? 0 : {CallName}.Length;"));
						}

						// Allocate native
						result.Add(String.Format($"{marshalType}[] native_{CallName} = new {marshalType} [cnt_{CallName}{(NullTerminated ? " + 1" : "")}];"));
						result.Add(String.Format("for (int i = 0; i < cnt_{0}; i++)", CallName));
						IGeneratable gen = Generatable;
						if (gen is IManualMarshaler)
							result.Add(String.Format("\tnative_{0} [i] = {1};", CallName, (gen as IManualMarshaler).AllocNative(CallName + "[i]")));
						else
							result.Add(String.Format("\tnative_{0} [i] = {1};", CallName, gen.CallByName(CallName + "[i]")));

						if (NullTerminated)
							result.Add(String.Format("native_{0} [cnt_{0}] = IntPtr.Zero;", CallName));
					} else {
						result.Add(String.Format($"{marshalType}[] native_{CallName};"));
					}
				}
				return result.ToArray();
			}
		}

		public override string CallString {
			get {
				string callString;

				if (FixedArrayLength.HasValue)
					return base.CallString;

				if (CSType != MarshalType) {
					callString = "native_" + CallName;
				} else {
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
					return new string[0];

				IGeneratable gen = Generatable;
				var result = new List<string>();

				if (string.IsNullOrEmpty(PassAs)) {
					if (gen is IManualMarshaler) {
						// Free manually allocated native pointers
						result.Add("for (int i = 0; i < native_" + CallName + ".Length" + (NullTerminated ? " - 1" : "") + "; i++) {");
						result.Add("\t" + (gen as IManualMarshaler).ReleaseNative("native_" + CallName + "[i]") + ";");
						result.Add("}");
					}
					return result.ToArray();
				}

				if (PassAs == "out") {
					if (FixedArrayLength.HasValue) {
						result.Add(String.Format($"int cnt_{CallName} = {FixedArrayLength};"));
					} else {
						result.Add(String.Format($"int cnt_{CallName} = native_{CallName} == null ? 0 : native_{CallName}.Length;"));
					}
					// Allocate managed
					result.Add(String.Format($"{Name} = new {CSType.TrimEnd('[', ']')}[cnt_{CallName}];"));
				}

				result.Add("for (int i = 0; i < native_" + CallName + ".Length" + (NullTerminated ? " - 1" : "") + "; i++) {");
				result.Add("\t" + CallName + " [i] = " + Generatable.FromNative("native_" + CallName + "[i]") + ";");
				if (gen is IManualMarshaler) {
					result.Add("\t" + (gen as IManualMarshaler).ReleaseNative("native_" + CallName + "[i]") + ";");
				}
				result.Add("}");
				return result.ToArray();
			}
		}
	}

	public class ArrayCountPair : ArrayParameter {

		Parameter count_param;
		bool invert;
		int count_index;

		public ArrayCountPair(XmlElement array_elem, XmlElement count_elem, bool invert, int count_index) : base(array_elem) {
			count_param = new Parameter(count_elem);
			this.invert = invert;
			this.count_index = count_index;
		}

		string CountCast {
			get {
				if (count_param.CSType == "int")
					return string.Empty;
				else
					return $"({count_param.CSType})";
			}
		}

		public override string[] Prepare {
			get {
				if (CSType == MarshalType && !FixedArrayLength.HasValue) {
					var result = new List<string>();
					if (PassAs == "out") {
						result.Add($"{count_param.CSType} cnt_{CallName};");
					} else {
						result.Add($"{count_param.CSType} cnt_{CallName} = {CountCast}({CallName} == null ? 0 : {CallName}.Length);");
					}
					return result.ToArray();
				} else {
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
				string nativeSignature = $"[MarshalAs(UnmanagedType.LPArray, SizeParamIndex={count_index})]{base.NativeSignature}";
				if (invert)
					return $"{count_param.NativeSignature}, {nativeSignature}";
				else
					return $"{nativeSignature}, {count_param.NativeSignature}";
			}
		}
	}
}