using Regress;

namespace Generator.Tests {
	[TestFixture]
	public class TestGSList {
		[Test]
		public void GSList_Nothing_Return() {
			var res = Global.TestGslistNothingReturn();

			CheckList(res);
		}

		[Test]
		public void GSList_Nothing_Return2() {
			var res = Global.TestGslistNothingReturn2();
			CheckList(res);
		}

		[Test]
		public void GSList_Null_In() {
			Global.TestGslistNullIn(null);
		}

		[Test]
		public void GSList_Null_Out() {
			var res = Global.TestGslistNullOut();
			Assert.That(res.Handle, Is.EqualTo(IntPtr.Zero));
		}

		[Test]
		public void GSList_Nothing_In() {
			GLib.SList l = CreateList();
			Global.TestGslistNothingIn(l);
		}

		[Test]
		public void GSList_Nothing_In2() {
			var l = CreateList();
			Global.TestGslistNothingIn2(l);
		}

		[Test]
		[Ignore("FIXME: not supported")]
		public void GSList_Container_Return() {
			//var res = Global.TestGslistContainerReturn();
		}

		[Test]
		public void GSList_Container_Everything_Return() {
			var res = Global.TestGslistEverythingReturn();
			CheckList(res);
		}

		[Test]
		public void GList_Paramaters_Use_The_Correct_Type() {
			// This test the generated API ensuring the array parameters have
			// the correct types.
			AnnotationObject annotationObject = new AnnotationObject(IntPtr.Zero);
			annotationObject.Data = new byte[1];
			annotationObject.Data2 = new string[1];
			// FIXME
			//annotationObject.Data3 = new int[1];
		}

		static void CheckList(string[] res) {
			Assert.Multiple(() => {
				Assert.That(res.Count, Is.EqualTo(3));
				Assert.That(res[0], Is.EqualTo("1"));
				Assert.That(res[1], Is.EqualTo("2"));
				Assert.That(res[2], Is.EqualTo("3"));
			});
		}

		static GLib.SList CreateList() {
			var l = new GLib.SList(typeof(string));
			l.Append("1");
			l.Append("2");
			l.Append("3");
			return l;
		}
	}
}