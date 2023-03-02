using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestGVariant {
		[Test]
		public void GVariant_As() {
			var ret = TestGvariantAs();

			Assert.That(ret.Type.ToString(), Is.EqualTo("as"));
		}

		[Test]
		public void GVariant_Asv() {
			var ret = TestGvariantAsv();

			Assert.That(ret.Type.ToString(), Is.EqualTo("a{sv}"));
		}

		[Test]
		public void GVariant_i() {
			var ret = TestGvariantI();

			Assert.That(ret.Type.ToString(), Is.EqualTo("i"));
		}

		[Test]
		public void GVariant_s() {
			var ret = TestGvariantS();

			Assert.That(ret.Type.ToString(), Is.EqualTo("s"));
		}

		[Test]
		public void GVariant_v() {
			var ret = TestGvariantV();

			Assert.That(ret.Type.ToString(), Is.EqualTo("v"));
		}

	}
}