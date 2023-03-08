using GtkSharp.Generation;
using GtkSharp.Parsing;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Generator.Tests.Integration {
	public class Pango {
		string testDir = ".";
		string tempDir = ".";
		const string METADATA = "Pango.metadata";
		const string API_RAW = "pango-api.raw";

		[SetUp]
		public void Setup() {
			testDir = TestContext.CurrentContext.TestDirectory;
			tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			Directory.CreateDirectory(tempDir);
			File.Copy(METADATA, Path.Combine(tempDir, METADATA));
			File.Copy(API_RAW, Path.Combine(tempDir, API_RAW));
		}

		[TearDown]
		public void TearDown() {
			try {
				Directory.Delete(tempDir, true);
			} catch { }
		}

		[Test]
		[NonParallelizable]
		public void GenerateCode_Pango_CodeIsGeneratedCorrectly() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(18, Statistics.EnumCount);
			Assert.AreEqual(7, Statistics.StructCount);
			Assert.AreEqual(4, Statistics.BoxedCount);
			Assert.AreEqual(65, Statistics.OpaqueCount);
			Assert.AreEqual(0, Statistics.IFaceCount);
			Assert.AreEqual(9, Statistics.ObjectCount);
			Assert.AreEqual(2, Statistics.CBCount);
			Assert.AreEqual(0, Statistics.PropCount);
			Assert.AreEqual(0, Statistics.SignalCount);
			Assert.AreEqual(249, Statistics.MethodCount);
			Assert.AreEqual(9, Statistics.CtorCount);
			Assert.AreEqual(22, Statistics.ThrottledCount);
		}

		private int GenerateCode() {
			Statistics.Reset();
			var fixedAPIPath = Path.Combine(tempDir, API_RAW);
			Fixup.FixupAPI(Path.Combine(tempDir, METADATA), fixedAPIPath);
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "pango-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Gtk",
				abi_cs_file: "pango-sharp-abi.cs",
				abi_c_file: "pango-sharp-abi.c",
				glue_filename: "pango-sharp-glue.c",
				glue_includes: "pango.h",
				gluelib_name: "pango-sharp-glue",
				schema_name: null,
				filenames: new List<string> { fixedAPIPath },
				includes: new List<string> { }
				);
		}
	}
}