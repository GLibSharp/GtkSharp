using GtkSharp.Generation;
using GtkSharp.Parsing;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Generator.Tests.Integration {
	public class Gio {
		string testDir = ".";
		string tempDir = ".";
		const string METADATA = "Gio.metadata";
		const string API_RAW = "gio-api.raw";

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
		public void GenerateCode_Gio_CodeIsGeneratedCorrectly() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(78, Statistics.EnumCount);
			Assert.AreEqual(7, Statistics.StructCount);
			Assert.AreEqual(2, Statistics.BoxedCount);
			Assert.AreEqual(92, Statistics.OpaqueCount);
			Assert.AreEqual(22, Statistics.IFaceCount);
			Assert.AreEqual(93, Statistics.ObjectCount);
			Assert.AreEqual(16, Statistics.CBCount);
			Assert.AreEqual(144, Statistics.PropCount);
			Assert.AreEqual(48, Statistics.SignalCount);
			Assert.AreEqual(1410, Statistics.MethodCount);
			Assert.AreEqual(83, Statistics.CtorCount);
			Assert.AreEqual(47, Statistics.ThrottledCount);
		}

		private int GenerateCode() {
			Statistics.Reset();
			var fixedAPIPath = Path.Combine(tempDir, API_RAW);
			Fixup.FixupAPI(Path.Combine(tempDir, METADATA), fixedAPIPath);
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
				filenames: new List<string> { fixedAPIPath },
				includes: new List<string> { }
				);
		}
	}
}