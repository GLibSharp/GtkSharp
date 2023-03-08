using GtkSharp.Generation;
using GtkSharp.Parsing;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Generator.Tests.Integration {
	public class Atk {
		string testDir = ".";
		string tempDir = ".";
		const string METADATA = "Atk.metadata";
		const string API_RAW = "atk-api.raw";

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
		public void GenerateCode_Atk_CodeIsGeneratedCorrectly() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(12, Statistics.EnumCount);
			Assert.AreEqual(4, Statistics.StructCount);
			Assert.AreEqual(2, Statistics.BoxedCount);
			Assert.AreEqual(4, Statistics.OpaqueCount);
			Assert.AreEqual(15, Statistics.IFaceCount);
			Assert.AreEqual(14, Statistics.ObjectCount);
			Assert.AreEqual(6, Statistics.CBCount);
			Assert.AreEqual(20, Statistics.PropCount);
			Assert.AreEqual(30, Statistics.SignalCount);
			Assert.AreEqual(503, Statistics.MethodCount);
			Assert.AreEqual(8, Statistics.CtorCount);
			Assert.AreEqual(1, Statistics.ThrottledCount);
		}

		private int GenerateCode() {
			Statistics.Reset();
			var fixedAPIPath = Path.Combine(tempDir, API_RAW);
			Fixup.FixupAPI(Path.Combine(tempDir, METADATA), fixedAPIPath);
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "atk-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Gtk",
				abi_cs_file: "atk-sharp-abi.cs",
				abi_c_file: "atk-sharp-abi.c",
				glue_filename: "atk-sharp-glue.c",
				glue_includes: "atk.h",
				gluelib_name: "atk-sharp-glue",
				schema_name: null,
				filenames: new List<string> { fixedAPIPath },
				includes: new List<string> { }
				);
		}
	}
}