using Regress;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Generator.Tests {
	[SetUpFixture]
	public class SetupClass {
		[OneTimeSetUp]
		public void Setup() {
			var builddir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
			builddir = Path.Combine(builddir, "..", "..", "..", "..", "..", "..", "..", "builddir");
			string prefix;
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
				prefix = Path.GetFullPath(Path.Combine(builddir, "prefix", "bin"));
			} else {
				prefix = Path.GetFullPath(Path.Combine(builddir, "prefix", "lib"));
			}
			var regressDir = Path.GetFullPath(Path.Combine(builddir, "Source", "tests", "generator", "regress"));
			NativeLibraryResolver.Init(new List<string>
			{
				prefix,
				regressDir
			});
			// Register type
			GLib.GType.Register(TestObj.GType, typeof(TestObj));
		}
	}
}