// GtkSharp.Generation.GenerationInfo.cs - Generation information class.
//
// Author: Mike Kestner <mkestner@ximian.com>
//
// Copyright (c) 2003-2008 Novell Inc.
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
	using System.Xml;

	public class GenerationInfo {

		string dir;
		string assembly_name;
		string gluelib_name;
		bool glue_enabled;
		StreamWriter sw;
		StreamWriter abiwriter = null;
		StreamWriter cabiwriter = null;
		StreamWriter glue_sw;
		string abicfile = null;
		string abicsfile = null;

		public GenerationInfo(XmlElement ns) {
			string ns_name = ns.GetAttribute("name");
			char sep = Path.DirectorySeparatorChar;
			dir = ".." + sep + ns_name.ToLower() + sep + "generated";
			assembly_name = ns_name.ToLower() + "-sharp";
		}

		public GenerationInfo(string dir, string assembly_name) :
			this(dir, assembly_name, "", "", "", "", "", "") { }

		public GenerationInfo(string dir, string assembly_name, string glue_filename,
				string glue_includes, string gluelib_name, string abi_c_file,
				string abi_cs_file, string abi_cs_usings) {
			this.dir = dir;
			this.assembly_name = assembly_name;
			this.gluelib_name = gluelib_name;
			abicfile = abi_c_file;
			abicsfile = abi_cs_file;
			InitializeWriters(glue_filename, glue_includes, gluelib_name, abi_cs_usings);
		}

		void InitializeWriters(string glue_filename, string glue_includes, string gluelib_name,
				string abi_cs_usings) {
			if (gluelib_name != String.Empty && glue_filename != String.Empty) {
				FileStream stream;
				try {
					stream = new FileStream(glue_filename, FileMode.Create, FileAccess.Write);
				} catch (Exception) {
					Console.Error.WriteLine("Unable to create specified glue file.  Glue will not be generated.");
					return;
				}

				glue_sw = new StreamWriter(stream);

				glue_sw.WriteLine("// This file was generated by the Gtk# code generator.");
				glue_sw.WriteLine("// Any changes made will be lost if regenerated.");
				glue_sw.WriteLine();

				if (glue_includes != "") {
					foreach (string header in glue_includes.Split(new char[] { ',', ' ' })) {
						if (header != "")
							glue_sw.WriteLine("#include <{0}>", header);
					}
					glue_sw.WriteLine("");
				}
				glue_enabled = true;
			}

			if (cabiwriter == null && abicfile != "" && abicsfile != "" && abi_cs_usings != "") {
				var stream = new FileStream(abicfile, FileMode.Create, FileAccess.Write);
				cabiwriter = new StreamWriter(stream);
				cabiwriter.WriteLine("// This file was generated by the Gtk# code generator.");
				cabiwriter.WriteLine("// Any changes made will be lost if regenerated.");
				cabiwriter.WriteLine();

				if (glue_includes != "") {
					foreach (string header in glue_includes.Split(new char[] { ',', ' ' })) {
						if (header != "")
							cabiwriter.WriteLine("#include <{0}>", header);
					}
					cabiwriter.WriteLine("");
				}

				cabiwriter.WriteLine("int main (int argc, char *argv[]) {");

				stream = new FileStream(abicsfile, FileMode.Create, FileAccess.Write);
				abiwriter = new StreamWriter(stream);
				abiwriter.WriteLine("// This file was generated by the Gtk# code generator.");
				abiwriter.WriteLine("// Any changes made will be lost if regenerated.");
				abiwriter.WriteLine();

				var name = "";
				foreach (string _using in abi_cs_usings.Split(new char[] { ',', ' ' })) {
					if (_using != "") {
						abiwriter.WriteLine("using {0};", _using);
						if (name == "")
							name = _using;
					}
				}
				abiwriter.WriteLine("using System;");
				abiwriter.WriteLine();
				abiwriter.WriteLine("namespace AbiTester {");
				abiwriter.WriteLine("\tclass ___" + name + " {");
				abiwriter.WriteLine("\t\tpublic static void Main (string[] args) {");
			}
		}

		public string AssemblyName {
			get {
				return assembly_name;
			}
		}

		public StreamWriter AbiWriter {
			get {
				return abiwriter;
			}
		}

		public StreamWriter CAbiWriter {
			get {
				return cabiwriter;
			}
		}

		public string Dir {
			get {
				return dir;
			}
		}

		public string GluelibName {
			get {
				return gluelib_name;
			}
		}

		public bool GlueEnabled {
			get {
				return glue_enabled;
			}
		}

		public StreamWriter GlueWriter {
			get {
				return glue_sw;
			}
		}

		public StreamWriter Writer {
			get {
				return sw;
			}
			set {
				sw = value;
			}
		}

		public void CloseWriters() {
			if (glue_sw != null)
				glue_sw.Close();

			if (cabiwriter != null) {
				cabiwriter.WriteLine("\treturn 0;");
				cabiwriter.WriteLine("}");
				cabiwriter.Close();

				abiwriter.WriteLine("\t\t}");
				abiwriter.WriteLine("\t}");
				abiwriter.WriteLine("}");
				abiwriter.Close();

			}
		}

		string member;
		public string CurrentMember {
			get {
				return typename + "." + member;
			}
			set {
				member = value;
			}
		}

		string typename;
		public string CurrentType {
			get {
				return typename;
			}
			set {
				typename = value;
			}
		}

		public StreamWriter OpenStream(string name, string namespce) {
			string gen_dir = Path.Combine(dir, namespce);
			Directory.CreateDirectory(gen_dir);

			string filename = Path.Combine(gen_dir, name + ".cs");

			FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(stream);

			sw.WriteLine("// This file was generated by the Gtk# code generator.");
			sw.WriteLine("// Any changes made will be lost if regenerated.");
			sw.WriteLine();

			return sw;
		}
	}
}