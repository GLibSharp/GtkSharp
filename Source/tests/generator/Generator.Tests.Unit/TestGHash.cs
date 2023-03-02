using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestGHash {
		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_Container() {
			var ret = TestGhashContainerReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_Everything() {
			var ret = TestGhashEverythingReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_NestedEverything() {
			var ret = TestGhashNestedEverythingReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_NestedEverything2() {
			var ret = TestGhashNestedEverythingReturn2();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_GValue() {
			var ret = TestGhashGvalueReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_Nothing() {
			var ret = TestGhashNothingReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_Return_Nothing_2() {
			var ret = TestGhashNothingReturn2();
		}

		[Test]
		public void Ghash_Return_Null() {
			var ret = TestGhashNullReturn();
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_In_GValue() {
			TestGhashGvalueIn(IntPtr.Zero);
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_In_Nothing() {
			TestGhashNothingIn(IntPtr.Zero);
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Ghash_In_Nothing_2() {
			TestGhashNothingIn2(IntPtr.Zero);
		}

		[Test]
		public void Ghash_In_Null() {
			TestGhashNullIn(IntPtr.Zero);
		}

		[Test]
		public void Ghash_Out_Null() {
			var ret = TestGhashNullOut();
			Assert.That(ret, Is.EqualTo(IntPtr.Zero));
		}
	}
}