using System.Runtime.InteropServices;
using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestMisc {
		[Test]
		public void Misc_CreateFundamentalHiddenClassInstance() {
			var res = TestCreateFundamentalHiddenClassInstance();

			Assert.That(res, Is.TypeOf(typeof(Regress.TestFundamentalObject)));
		}

		[Test]
		public void Misc_DateInGvalue() {
			var res = TestDateInGvalue();

			Assert.That(res.Val, Is.TypeOf(typeof(GLib.Date)));
		}

		[Test]
		public void Misc_ErrorQuark_Def() {
			var res = TestDefErrorQuark();

			// FIXME: the value changes depending on how the test is launched
			// and the order in wich things are registered
			//Assert.That(res, Is.EqualTo(56));
		}

		[Test]
		public void Misc_ErrorQuark() {
			var res = TestErrorQuark();

			// FIXME: the value changes depending on how the test is launched
			// and the order in wich things are registered
			//Assert.That(res, Is.EqualTo(56));
		}

		[Test]
		public void Misc_ErrorQuark_Unconventional() {
			var res = TestUnconventionalErrorQuark();

			// FIXME: the value changes depending on how the test is launched
			// and the order in wich things are registered
			//Assert.That(res, Is.EqualTo(56));
		}

		[Test]
		public void Misc_Enum_Param() {
			var res = TestEnumParam(Regress.TestEnum.Value3);

			Assert.That(res, Is.EqualTo("value3"));
		}

		[Test]
		public void Misc_Enum_Param_Unsigned() {
			var res = TestUnsignedEnumParam(Regress.TestEnumUnsigned.Value2);

			Assert.That(res, Is.EqualTo("value2"));
		}

		[Test]
		public void Misc_GType() {
			var res = TestGtype(Regress.TestObj.GType);

			Assert.That(res, Is.EqualTo(Regress.TestObj.GType));
		}

		[Test]
		public void Misc_GValue_In_int() {
			var res = TestIntValueArg(new GLib.Value(100));

			Assert.That(res, Is.EqualTo(100));
		}


		[Test]
		public void Misc_GValue_Return_int() {
			var res = TestValueReturn(1);

			Assert.That(res.Val, Is.EqualTo(1));
		}

		[Test]
		public void Misc_Multi() {
			var res = TestIntValueArg(new GLib.Value(100));

			Assert.That(res, Is.EqualTo(100));
		}

		[Test]
		public void Misc_MultiDoubleArgs() {
			const double inParam = 1d;
			TestMultiDoubleArgs(inParam, out double one, out double two);

			Assert.That(one, Is.EqualTo(inParam * 2));
			Assert.That(two, Is.EqualTo(inParam * 3));
		}

		[Test]
		public void Misc_MultilineDocComments() {
			TestMultilineDocComments();
		}

		[Test]
		public void Misc_NestedParameter() {
			TestNestedParameter(2);
		}

		[Test]
		public void Misc_Timet() {
			var ret = TestTimet(long.MaxValue);

			Assert.That(ret, Is.EqualTo(long.MaxValue));
		}


		[Test]
		public void Misc_TortureSignature0() {
			int intInVal = 5;
			uint uintInVal = 5;
			string stringInVal = "foo";

			TestTortureSignature0(intInVal, out double y, out int z, stringInVal, out int q, uintInVal);

			Assert.That(y, Is.EqualTo(intInVal));
			Assert.That(z, Is.EqualTo(intInVal * 2));
			Assert.That(q, Is.EqualTo(stringInVal.Length + uintInVal));
		}

		[Test]
		public void Misc_TortureSignature1() {
			int intInVal = 5;
			uint uintInVal = 5;
			string stringInVal = "foo";

			Assert.Throws<GLib.GException>(
				() => TestTortureSignature1(intInVal, out double y, out int z, stringInVal, out int q, uintInVal));
		}

		[Test]
		public void Misc_TortureSignature2() {
			int intInVal = 5;
			uint uintInVal = 5;
			string stringInVal = "foo";

			TestTortureSignature2(intInVal, () => 6, out double y, out int z, stringInVal, out int q, uintInVal);

			Assert.That(y, Is.EqualTo(intInVal));
			Assert.That(z, Is.EqualTo(intInVal * 2));
			Assert.That(q, Is.EqualTo(stringInVal.Length + uintInVal));
		}
	}
}