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
			var prefixBuilddir = Path.Combine(builddir, "prefix");
			string prefix;

			if (Directory.Exists(prefixBuilddir)) {
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
					prefix = Path.GetFullPath(Path.Combine(builddir, "prefix", "bin"));
				} else {
					prefix = Path.GetFullPath(Path.Combine(builddir, "prefix", "lib"));
				}
			} else {
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
					prefix = "/usr/bin";
				} else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
					prefix = "/opt/homebrew/lib";
				} else {
					throw new Exception("On windows tests can only be run with a build installed in builddir/prefix");
				}
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
