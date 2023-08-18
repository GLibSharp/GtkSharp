using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Generator.Tests.Integration {
	public static class Utils {
		public static (IEnumerable<Diagnostic> errors, IEnumerable<Diagnostic> warnings) Compile(string sourcesDir, string dllName) {
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
			var result = compilation.Emit(Path.Combine(sourcesDir, dllName));
			var errors = result.Diagnostics
				.Where(d => d.Severity == DiagnosticSeverity.Error);
			var warnings = result.Diagnostics
				.Where(d => d.Severity == DiagnosticSeverity.Warning)
				.Where(d => d.Id != "CS1701");
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