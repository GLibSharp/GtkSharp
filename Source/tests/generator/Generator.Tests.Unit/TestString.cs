using System.Runtime.InteropServices;
using static Regress.Global;

namespace Generator.Tests {
	public class TestString {
		const string utf8_const = "const ♥ utf8";
		const string utf8_nonconst = "nonconst ♥ utf8";


		[Test]
		public void String_Utf8_Return_Const() {
			var res = TestUtf8ConstReturn();
			Assert.That(res, Is.EqualTo(utf8_const));
		}

		[Test]
		public void String_Utf8_Return_NonConst() {
			var res = TestUtf8NonconstReturn();
			Assert.That(res, Is.EqualTo(utf8_nonconst));
		}

		[Test]
		public void String_Utf8_In_Const() {
			TestUtf8ConstIn(utf8_const);
		}

		[Test]
		public void String_Utf8_Out() {
			var res = TestUtf8Out();
			Assert.That(res, Is.EqualTo(utf8_nonconst));
		}

		[Test]
		public void String_Utf8_InOut() {
			var res = utf8_const;
			TestUtf8Inout(ref res);
			Assert.That(res, Is.EqualTo(utf8_nonconst));
		}

		[Test]
		public void String_Utf8_Int_Out() {
			var res = TestIntOutUtf8(utf8_const);
			Assert.That(res, Is.EqualTo(utf8_const.Length));
		}

		[Test]
		public void String_Utf8_Out_Out() {
			TestUtf8OutOut(out string out0, out string out1);
			Assert.Multiple(() => {
				Assert.That(out0, Is.EqualTo("first"));
				Assert.That(out1, Is.EqualTo("second"));
			});
		}

		[Test]
		public void String_Utf8_Out_Return_NonConst() {
			var res = TestUtf8OutNonconstReturn(out string outParam);
			Assert.Multiple(() => {
				Assert.That(res, Is.EqualTo("first"));
				Assert.That(outParam, Is.EqualTo("second"));
			});
		}

		[Test]
		public void String_Utf8_Out_Null() {
			var res = TestUtf8NullOut();
			Assert.That(res, Is.Null);
		}

		[Test]
		public void String_Utf8_In_Null() {
			TestUtf8NullIn(null);
		}

		[Test]
		public void String_Strv_In() {
			TestStrvIn(new string[3] { "1", "2", "3" });
		}

		[Test]
		public void String_Strv_Out() {
			var res = TestStrvOut();
			Assert.That(res, Is.EqualTo(new string[5]
			{
				"thanks",
				"for",
				"all",
				"the",
				"fish"
			}));
		}

		[Test]
		public void String_Strv_Out_Container() {
			var res = TestStrvOutContainer();
			Assert.That(res, Is.EqualTo(new string[3] { "1", "2", "3" }));
		}

		[Test]
		public void String_Strv_Out_Arg() {
			var res = TestStrvOutarg();
			Assert.That(res, Is.EqualTo(new string[3] { "1", "2", "3" }));
		}

		[Test]
		[Ignore("FIXME: fails in macOS with Invalid byte sequence in conversion input")]
		public void String_Filename() {
			var res = TestFilenameReturn();
			//Assert.That(res, Is.EqualTo();
		}
	}
}