using Regress;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Generator.Tests {
	[SetUpFixture]
	public class SetupClass {
		[OneTimeSetUp]
		public void Setup() {
			NativeLibraryResolver.Init(SearchDirs.SEARCH_DIRS.Split(";").ToList());
			// Register type
			GLib.GType.Register(TestObj.GType, typeof(TestObj));
		}
	}
}