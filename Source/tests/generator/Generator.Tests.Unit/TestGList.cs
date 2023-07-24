using Regress;

namespace Generator.Tests {
	[TestFixture]
	public class TestGList {
		[Test]
		public void GList_Nothing_Return() {
			var res = Global.TestGlistNothingReturn();

			CheckList(res);
		}

		[Test]
		public void GList_Nothing_Return2() {
			var res = Global.TestGlistNothingReturn2();

			CheckList(res);
		}

		[Test]
		public void GList_Null_In() {
			Global.TestGlistNullIn(null);
		}

		[Test]
		public void GList_Null_Out() {
			var res = Global.TestGlistNullOut();
			Assert.That(res.Handle, Is.EqualTo(IntPtr.Zero));
		}

		[Test]
		public void GList_Nothing_In() {
			var l = new GLib.List(typeof(string));
			l.Append("1");
			l.Append("2");
			l.Append("3");
			Global.TestGlistNothingIn(l);
		}

		[Test]
		public void GList_Nothing_In2() {
			var l = new GLib.List(typeof(string));
			l.Append("1");
			l.Append("2");
			l.Append("3");
			Global.TestGlistNothingIn2(l);
		}

		[Test]
		[Ignore("FIXME: not supported")]
		public void GList_Container_Return() {
			//var res = Global.TestGlistContainerReturn();
		}

		[Test]
		public void GList_Container_Everything_Return() {
			var res = Global.TestGlistEverythingReturn();
			CheckList(res);
		}

		[Test]
		[Ignore("FIXME")]
		public void GList_Gtype_Container_In() {
			var l = new GLib.List(typeof(GLib.GType));
			l.Append(Regress.TestObj.GType);
			l.Append(Regress.TestSubObj.GType);
			Global.TestGlistGtypeContainerIn(l);
		}

		private static void CheckList(string[] res) {
			Assert.Multiple(() => {
				Assert.That(res.Count, Is.EqualTo(3));
				Assert.That(res[0], Is.EqualTo("1"));
				Assert.That(res[1], Is.EqualTo("2"));
				Assert.That(res[2], Is.EqualTo("3"));
			});
		}
	}
}