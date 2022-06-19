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
        }
    }
}