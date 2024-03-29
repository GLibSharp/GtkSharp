// GtkSharp.Generation.ClassGen.cs - The Class Generatable.
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// Copyright (c) 2001-2003 Mike Kestner
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
	using System.Collections;
	using System.IO;
	using System.Text;
	using System.Xml;

	public class ClassGen : ClassBase {

		public ClassGen(XmlElement ns, XmlElement elem) : base(ns, elem) { }

		public override string AssignToName {
			get {
				return String.Empty;
			}
		}

		public override string MarshalType {
			get {
				return String.Empty;
			}
		}

		public override string CallByName() {
			return String.Empty;
		}

		public override string CallByName(string var) {
			return String.Empty;
		}

		public override string FromNative(string var) {
			return String.Empty;
		}

		public override void Generate(GenerationInfo gen_info) {
			gen_info.CurrentType = QualifiedName;

			StreamWriter sw = gen_info.Writer = gen_info.OpenStream(Name, NS);

			sw.WriteLine("namespace " + NS + " {");
			sw.WriteLine();
			sw.WriteLine("\tusing System;");
			sw.WriteLine("\tusing System.Runtime.InteropServices;");
			sw.WriteLine();

			sw.WriteLine("#region Autogenerated code");
			if (IsDeprecated)
				sw.WriteLine("\t[Obsolete]");
			sw.Write("\t{0} partial class " + Name, IsInternal ? "internal" : "public");
			sw.WriteLine(" {");
			sw.WriteLine();

			GenConstants(gen_info);
			GenProperties(gen_info, null);
			GenMethods(gen_info, null, null);

			sw.WriteLine("#endregion");

			sw.WriteLine("\t}");
			sw.WriteLine("}");

			sw.Close();
			gen_info.Writer = null;
		}
	}
}