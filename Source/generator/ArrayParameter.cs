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
		protected IGeneratable generatable;

		public ArrayParameter(XmlElement elem) : base(elem) {
			null_terminated = elem.GetAttributeAsBoolean("null_term_array");
			if (elem.HasAttribute("array_len"))
				FixedArrayLength = Int32.Parse(elem.GetAttribute("array_len"));

			if (elem.HasAttribute("array_length_param_index")) {
				ArrayLengthParamIndex = int.Parse(elem.GetAttribute("array_length_param_index"));
			} else {
				ArrayLengthParamIndex = -1;
			}

			if (IsString) {
				generatable = new ArrayStringGen(CType, this);
			} else {
				generatable = base.Generatable;
			}
		}

		public int ArrayLengthParamIndex { get; }

		public override IGeneratable Generatable => generatable;

		public override string MarshalType {
			get {
				if (Generatable is StructBase) {
					return CSType;
				} else {
					return base.MarshalType;
				}
			}
		}

		public bool NullTerminated => null_terminated;

		public override bool IsString => CSType == "string[]";

		public int? FixedArrayLength { get; private set; }

		public override string NativeSignature {
			get {
				if (!IsString && FixedArrayLength > 0) {
					return $"[MarshalAs(UnmanagedType.LPArray, SizeConst={FixedArrayLength})]{base.NativeSignature}";
				} else {
					return base.NativeSignature;
				}
			}
		}

		public virtual string CountCallName => $"cnt_{CallName}";

		public override string[] Prepare {
			get {
				if (IsString) {
					return base.Prepare;
				}

				var result = new List<string>();

				if (CSType != MarshalType) {
					var marshalType = MarshalType.TrimEnd('[', ']');
					if (PassAs != "out") {
						if (FixedArrayLength.HasValue) {
							result.Add(String.Format($"int {CountCallName} = {FixedArrayLength};"));
						} else {
							result.Add(String.Format($"int {CountCallName} = {CallName} == null ? 0 : {CallName}.Length;"));
						}

						AllocateNative(result, marshalType);
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
				if (IsString) {
					return base.Finish;
				}
				if (CSType == MarshalType) {
					return new string[0];
				}

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
						result.Add(String.Format($"int {CountCallName} = {FixedArrayLength};"));
					} else {
						result.Add(String.Format($"int {CountCallName} = native_{CallName} == null ? 0 : native_{CallName}.Length;"));
					}
					// Allocate managed
					result.Add(String.Format($"{Name} = new {CSType.TrimEnd('[', ']')}[{CountCallName}];"));
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

		protected void AllocateNative(List<string> result, string marshalType) {
			// Allocate native
			result.Add(String.Format($"{marshalType}[] native_{CallName} = new {marshalType} [{CountCallName}{(NullTerminated ? " + 1" : "")}];"));
			result.Add(String.Format("for (int i = 0; i < {0}; i++)", CountCallName));
			IGeneratable gen = Generatable;
			if (gen is IManualMarshaler)
				result.Add(String.Format("\tnative_{0} [i] = {1};", CallName, (gen as IManualMarshaler).AllocNative(CallName + "[i]")));
			else
				result.Add(String.Format("\tnative_{0} [i] = {1};", CallName, gen.CallByName(CallName + "[i]")));

			if (NullTerminated)
				result.Add(String.Format("native_{0} [cnt_{0}] = IntPtr.Zero;", CallName));
		}
	}

	public class ArrayCountPair : ArrayParameter {

		Parameter count_param;
		bool invert;
		int count_index;
		bool skip_count;

		public ArrayCountPair(Parameter array_param, Parameter count_param, bool invert, int count_index, bool skip_count = false) : base(array_param.Element) {
			this.count_param = count_param;
			this.invert = invert;
			this.count_index = count_index;
			this.skip_count = skip_count;
		}

		public Parameter CountParameter => count_param;

		public override string CountCallName => $"{CountParameter.CallName}";

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
				var result = new List<string>();

				if (PassAs != "out" && !skip_count) {
					result.Add($"{count_param.CSType} {CountCallName} = {CountCast}({CallName} == null ? 0 : {CallName}.Length);");
				}

				if (CSType != MarshalType) {
					if (IsString) {
						result.AddRange(base.Prepare);
					} else {
						var marshalType = MarshalType.TrimEnd('[', ']');
						AllocateNative(result, marshalType);
					}
				}
				return result.ToArray();
			}
		}

		public override string CallString {
			get {
				string pass_ass = string.IsNullOrEmpty(count_param.PassAs) ? "" : $"{count_param.PassAs} ";
				string count_param_call;

				if (count_param.PassAs == "out") {
					count_param_call = $"{pass_ass}{count_param.MarshalType} {CountCallName}";
				} else if (count_param.PassAs == "ref") {
					count_param_call = $"{pass_ass}{CountCallName}";
				} else {
					var call_name = $"{CountCallName}";
					if (count_param.Generatable is LPUGen) {
						call_name = $"(uint){call_name}";
					}
					count_param_call = count_param.Generatable.CallByName(call_name);
				}

				if (skip_count) {
					return base.CallString;
				} else if (invert) {
					return $"{count_param_call}, {base.CallString}";
				} else {
					return $"{base.CallString}, {count_param_call}";
				}
			}
		}

		public override string NativeSignature {
			get {
				string nativeSignature = base.NativeSignature;
				if (!IsString) {
					nativeSignature = $"[MarshalAs(UnmanagedType.LPArray, SizeParamIndex={count_index})]{nativeSignature}";
				}
				if (skip_count) {
					return nativeSignature;
				} else if (invert) {
					return $"{count_param.NativeSignature}, {nativeSignature}";
				} else {
					return $"{nativeSignature}, {count_param.NativeSignature}";
				}
			}
		}
	}
}