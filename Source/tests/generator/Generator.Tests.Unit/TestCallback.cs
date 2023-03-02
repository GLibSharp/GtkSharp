using System.Runtime.InteropServices;
using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestCallback {
		[Test]
		public void Callback_Int_Return() {
			var ret = TestCallback(() => 2);

			Assert.That(ret, Is.EqualTo(2));
		}

		[Test]
		public void Callback_Noptr() {
			TestNoptrCallback();
		}

		[Test]
		public void Callback_Gerror_Null() {
			GLib.GException? exception = null;
			TestNullGerrorCallback(e => {
				if (e != IntPtr.Zero) {
					exception = new GLib.GException(e);
				}
			});

			Assert.That(exception, Is.Null);
		}

		[Test]
		public void Callback_Gerror() {
			GLib.GException? exception = null;
			TestGerrorCallback(e => {
				exception = new GLib.GException(e, false);
			});

			Assert.That(exception?.Message, Is.EqualTo("regression test error"));
		}

		[Test]
		[Ignore("FIXME: check how to test it correctly")]
		public void Callback_Async() {
			int ret = 0;
			TestCallbackAsync(() => ret = 2);

			Assert.That(ret, Is.EqualTo(2));
		}

		[Test]
		public void Callback_DestroyNotify() {
			var ret = TestCallbackDestroyNotify(() => 2);

			Assert.That(ret, Is.EqualTo(2));
		}

		[Test]
		public void Callback_DestroyNotify_NoUserData() {
			var ret = TestCallbackDestroyNotifyNoUserData(() => 2);

			Assert.That(ret, Is.EqualTo(2));
		}

		[Test]
		public void Callback_ReturnFull() {
			bool called = false;
			Regress.TestObj testObj = new Regress.TestObj();
			TestCallbackReturnFull(() => {
				called = true;
				return testObj;
			});

			Assert.That(called, Is.True);
		}

		[Test]
		public void Callback_UserData() {
			var ret = TestCallbackUserData(() => 2);
			Assert.That(ret, Is.EqualTo(2));
		}


		[Test]
		[Ignore("FIXME: check how to test correctly")]
		public void Callback_Thaw_Async() {
			var ret = TestCallbackThawAsync();
			Assert.That(ret, Is.EqualTo(4));
		}

		[Test]
		[Ignore("FIXME: A callback was made on a garbage collected delegate of type")]
		public void Callback_Thaw_Notifications() {
			var ret = TestCallbackThawNotifications();
			Assert.That(ret, Is.EqualTo(4));
		}

		[Test]
		[Ignore("FIXME: HashTable bindings missing in unit tests")]
		public void Callback_HashTable() {
			//TestHashTableCallback();
		}

		[Test]
		public void Callback_Multi() {
			int called = 0;
			var res = TestMultiCallback(() => called++);

			Assert.That(res, Is.EqualTo(1));
			Assert.That(called, Is.EqualTo(2));
		}
	}
}