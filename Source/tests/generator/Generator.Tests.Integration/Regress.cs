using GtkSharp.Generation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Generator.Tests.Integration.Utils;

namespace Generator.Tests.Integration {
	public class Regress {
		string testDir = ".";
		string tempDir = ".";

		[SetUp]
		public void Setup() {
			testDir = TestContext.CurrentContext.TestDirectory;
			tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			Directory.CreateDirectory(tempDir);
		}

		[TearDown]
		public void TearDown() {
			try {
				Directory.Delete(tempDir, true);
			} catch { }
		}

		[Test]
		public void GenerateCode_Regress_CodeIsGeneratedCorrectly() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(Statistics.EnumCount, 22);
			Assert.AreEqual(Statistics.StructCount, 20);
			Assert.AreEqual(Statistics.BoxedCount, 9);
			Assert.AreEqual(Statistics.OpaqueCount, 5);
			Assert.AreEqual(Statistics.IFaceCount, 3);
			Assert.AreEqual(Statistics.ObjectCount, 12);
			Assert.AreEqual(Statistics.CBCount, 20);
			Assert.AreEqual(Statistics.PropCount, 21);
			Assert.AreEqual(Statistics.SignalCount, 17);
			Assert.AreEqual(Statistics.MethodCount, 301);
			Assert.AreEqual(Statistics.CtorCount, 25);
			Assert.AreEqual(Statistics.ThrottledCount, 20);
		}


		[Test]
		public void GenerateCode_Regress_CodeCanBeCompiled() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			var (errors, warnings) = Compile(tempDir, "regress-sharp.dll");
			Assert.AreEqual(1, errors.Count());
			Assert.AreEqual(4, warnings.Count());
		}

		private int GenerateCode() {
			Statistics.Reset();

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
	}
}