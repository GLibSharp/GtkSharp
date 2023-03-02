using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestBoxed {
		[Test]
		public void Boxed_NotAStatic() {
			TestBoxedsNotAStatic();
		}

		[Test]
		public void Boxed_NotAMethod() {
			TestBoxedsNotAMethod(new Regress.TestBoxed());
		}
	}
}