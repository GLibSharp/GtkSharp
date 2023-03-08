using GtkSharp.Generation;
using GtkSharp.Parsing;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Generator.Tests.Integration {
	[TestFixture]
	[NonParallelizable]
	public class Gtk {
		string testDir = ".";
		string tempDir = ".";
		const string METADATA = "Gtk.metadata";
		const string API_RAW = "gtk-api.raw";

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
			Assert.AreEqual(115, Statistics.EnumCount);
			Assert.AreEqual(14, Statistics.StructCount);
			Assert.AreEqual(5, Statistics.BoxedCount);
			Assert.AreEqual(266, Statistics.OpaqueCount);
			Assert.AreEqual(21, Statistics.IFaceCount);
			Assert.AreEqual(227, Statistics.ObjectCount);
			Assert.AreEqual(64, Statistics.CBCount);
			Assert.AreEqual(1300, Statistics.PropCount);
			Assert.AreEqual(454, Statistics.SignalCount);
			Assert.AreEqual(2940, Statistics.MethodCount);
			Assert.AreEqual(280, Statistics.CtorCount);
			Assert.AreEqual(209, Statistics.ThrottledCount);
		}

		private int GenerateCode() {
			Statistics.Reset();
			var fixedAPIPath = Path.Combine(tempDir, API_RAW);
			Fixup.FixupAPI(Path.Combine(tempDir, METADATA), fixedAPIPath);
			return CodeGenerator.GenerateCode(
				dir: tempDir,
				assembly_name: "gtk-sharp",
				gapidir: testDir,
				abi_cs_usings: "GLib,Gtk",
				abi_cs_file: "gtk-sharp-abi.cs",
				abi_c_file: "gtk-sharp-abi.c",
				glue_filename: "gtk-sharp-glue.c",
				glue_includes: "gtk.h",
				gluelib_name: "gtk-sharp-glue",
				schema_name: null,
				filenames: new List<string> { fixedAPIPath },
				includes: new List<string> { "gdk-api.raw", "gio-api.raw", "atk-api.raw" }
				);
		}
	}
}