using GtkSharp.Generation;
using NUnit.Framework;
using System.Collections.Generic;

namespace IntegrationTests
{
    public class Tests
    {
        string testDir=".";

        [SetUp]
        public void Setup()
        {
            testDir = TestContext.CurrentContext.TestDirectory;
        }

        [Test]
        public void GenerateCode_Regress_CodeGenerated ()
        {
         
            var res = CodeGenerator.GenerateCode(
                dir: testDir,
                assembly_name: "regress-sharp",
                gapidir: testDir,
                abi_cs_usings: "GLib,Regress",
                abi_cs_file: "regress-sharp-abi.cs",
                abi_c_file: "regress-sharp-abi.c",
                glue_filename: "regress-sharp-glue.c",
                glue_includes: "regress.h",
                gluelib_name: "regress-sharp-glue",
                schema_name:null,
                filenames: new List<string> { "regress-sharp-api.xml" },
                includes: new List<string> { }
                );
            Assert.AreEqual(0, res);
            Assert.AreEqual(Statistics.EnumCount, 22);
            Assert.AreEqual(Statistics.StructCount, 20);
            Assert.AreEqual(Statistics.BoxedCount, 9);
            Assert.AreEqual(Statistics.OpaqueCount, 5);
            Assert.AreEqual(Statistics.IFaceCount, 3);
            Assert.AreEqual(Statistics.ObjectCount, 12);
            Assert.AreEqual(Statistics.CBCount, 18);
            Assert.AreEqual(Statistics.PropCount, 21);
            Assert.AreEqual(Statistics.SignalCount, 14);
            Assert.AreEqual(Statistics.MethodCount, 267);
            Assert.AreEqual(Statistics.CtorCount, 24);
            Assert.AreEqual(Statistics.ThrottledCount, 47);
        }
    }
}