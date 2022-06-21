using GtkSharp.Generation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IntegrationTests {
	public class Tests {
		string testDir = ".";
		string tempDir = ".";

		[SetUp]
		public void Setup() {
			testDir = TestContext.CurrentContext.TestDirectory;
			tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			Directory.CreateDirectory(tempDir);
			Statistics.Reset();
		}

		[TearDown]
		public void TearDown() {
			try {
				Directory.Delete(tempDir, true);
			} catch { }
		}

		[Test]
		public void GenerateCode_Regress_CodeIsGeneratedCorrectly() {
			int res = GenerateRegressCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(Statistics.EnumCount, 22);
			Assert.AreEqual(Statistics.StructCount, 21);
			Assert.AreEqual(Statistics.BoxedCount, 9);
			Assert.AreEqual(Statistics.OpaqueCount, 5);
			Assert.AreEqual(Statistics.IFaceCount, 3);
			Assert.AreEqual(Statistics.ObjectCount, 12);
			Assert.AreEqual(Statistics.CBCount, 20);
			Assert.AreEqual(Statistics.PropCount, 22);
			Assert.AreEqual(Statistics.SignalCount, 17);
			Assert.AreEqual(Statistics.MethodCount, 304);
			Assert.AreEqual(Statistics.CtorCount, 25);
			Assert.AreEqual(Statistics.ThrottledCount, 17);
		}


		[Test]
		public void GenerateCode_Regress_CodeCanBeCompiled() {
			int res = GenerateRegressCode();
			Assert.AreEqual(0, res);
			var result = Compile(tempDir, "regress-sharp.dll");
			Assert.AreEqual(33, result.errors.Count(d => d.Severity == DiagnosticSeverity.Error));
			Assert.AreEqual(5, result.warnings.Count(d => d.Severity == DiagnosticSeverity.Warning));
		}

		[Test]
		public void GenerateCode_Gio_CodeIsGeneratedCorrectly() {
			int res = GenerateGioCode();
			Assert.AreEqual(0, res);
		}

		int GenerateRegressCode() {
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "regress-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Regress",
				abi_cs_file: "regress-sharp-abi.cs",
				abi_c_file: "regress-sharp-abi.c",
				glue_filename: "regress-sharp-glue.c",
				glue_includes: "regress.h",
				gluelib_name: "regress-sharp-glue",
				schema_name: null,
				filenames: new List<string> { "regress-sharp-api.xml" },
				includes: new List<string> { }
				);
		}

		int GenerateGioCode() {
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "gio-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Gio",
				abi_cs_file: "gio-sharp-abi.cs",
				abi_c_file: "gio-sharp-abi.c",
				glue_filename: "gio-sharp-glue.c",
				glue_includes: "gio.h",
				gluelib_name: "gio-sharp-glue",
				schema_name: null,
				filenames: new List<string> { "gio-api.raw" },
				includes: new List<string> { }
				);
		}

		(List<Diagnostic> errors, List<Diagnostic> warnings) Compile(string sourcesDir, string dllName) {
			DirectoryInfo d = new DirectoryInfo(sourcesDir);
			string[] sourceFiles = d.EnumerateFiles("*.cs", SearchOption.AllDirectories)
				.Select(a => a.FullName).ToArray();

			List<SyntaxTree> trees = new List<SyntaxTree>();
			foreach (string file in sourceFiles) {
				string code = File.ReadAllText(file);
				SyntaxTree tree = CSharpSyntaxTree.ParseText(code, path: file);
				trees.Add(tree);
			}

			// Reference Microsoft.NETCore.App
			var netCoreDir = new DirectoryInfo(Path.GetDirectoryName(typeof(object).Assembly.Location)!);
			List<PortableExecutableReference> references = netCoreDir.EnumerateFiles("*.dll", SearchOption.AllDirectories)
				.Where(f => f.Name.StartsWith("System"))
				.Where(f => !f.Name.EndsWith("Native.dll"))
				.Select(f => MetadataReference.CreateFromFile(f.FullName)).ToList();

			// Reference glib-sharp
			references.Add(MetadataReference.CreateFromFile(typeof(GLib.AbiField).Assembly.Location));
			// Reference gio-sharp
			references.Add(MetadataReference.CreateFromFile(typeof(GLib.GioStream).Assembly.Location));

			var compilation = CSharpCompilation.Create(dllName,
				   trees,
				   references,
				   new CSharpCompilationOptions(
					   OutputKind.DynamicallyLinkedLibrary,
					   allowUnsafe: true));
			var result = compilation.Emit(Path.Combine(tempDir, dllName));
			var errors = result.Diagnostics
				.Where(d => d.Severity == DiagnosticSeverity.Error)
				.ToList();
			var warnings = result.Diagnostics
				.Where(d => d.Severity == DiagnosticSeverity.Warning)
				.Where(d => d.Id != "CS1701")
				.ToList();
			foreach (var diag in errors) {
				Console.WriteLine(diag);
			}
			foreach (var diag in warnings) {
				Console.WriteLine(diag);
			}
			return (errors, warnings);
		}
	}
}