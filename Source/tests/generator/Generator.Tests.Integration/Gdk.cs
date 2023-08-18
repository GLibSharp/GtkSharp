using GtkSharp.Generation;
using GtkSharp.Parsing;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Generator.Tests.Integration {
	public class Gdk {
		string testDir = ".";
		string tempDir = ".";
		const string METADATA = "Gdk.metadata";
		const string API_RAW = "gdk-api.raw";

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
		public void GenerateCode_Gdk_CodeIsGeneratedCorrectly() {
			int res = GenerateCode();
			Assert.AreEqual(0, res);
			Assert.AreEqual(54, Statistics.EnumCount);
			Assert.AreEqual(14, Statistics.StructCount);
			Assert.AreEqual(1, Statistics.BoxedCount);
			Assert.AreEqual(43, Statistics.OpaqueCount);
			Assert.AreEqual(1, Statistics.IFaceCount);
			Assert.AreEqual(26, Statistics.ObjectCount);
			Assert.AreEqual(4, Statistics.CBCount);
			Assert.AreEqual(37, Statistics.PropCount);
			Assert.AreEqual(35, Statistics.SignalCount);
			Assert.AreEqual(422, Statistics.MethodCount);
			Assert.AreEqual(13, Statistics.CtorCount);
			Assert.AreEqual(78, Statistics.ThrottledCount);
		}

		private int GenerateCode() {
			Statistics.Reset();
			var fixedAPIPath = Path.Combine(tempDir, API_RAW);
			Fixup.FixupAPI(Path.Combine(tempDir, METADATA), fixedAPIPath);
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "gdk-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Gdk",
				abi_cs_file: "gdk-sharp-abi.cs",
				abi_c_file: "gdk-sharp-abi.c",
				glue_filename: "gdk-sharp-glue.c",
				glue_includes: "gdk.h",
				gluelib_name: "gdk-sharp-glue",
				schema_name: null,
				filenames: new List<string> { fixedAPIPath },
				includes: new List<string> { }
				);
		}
	}
}