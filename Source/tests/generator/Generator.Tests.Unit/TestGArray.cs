using Regress;

namespace Generator.Tests {
	[TestFixture]
	public class TestGArray {
		[Test]
		public void GArray_Container_Return() {
			var res = Global.TestGarrayContainerReturn();
			Assert.That(res, Has.Length.EqualTo(1));
			Assert.That(res[0], Is.EqualTo("regress"));
		}

		[Test]
		public void GArray_Full_Return() {
			var res = Global.TestGarrayFullReturn();
			Assert.That(res, Has.Length.EqualTo(1));
			Assert.That(res[0], Is.EqualTo("regress"));
		}
	}
}