using Regress;
using static Regress.Global;

namespace Generator.Tests {
	public class TestArray {
		[Test]
		public void Array_Callback() {
			(int[] one, string[] two)? res = null;
			TestCallbackArray cb = new TestCallbackArray(
				(int[] one, string[] two) => {
					res = (one, two);
					return 1;
				}
			);
			var ret = TestArrayCallback(cb);

			Assert.That(res, Is.Not.Null);
			var notNullRes = res!.Value;
			Assert.That(ret, Is.EqualTo(2));
		}

		// This test can't work with the bindings since it expects the callback
		// to modifiy the size of the array. The size of the inout array is defined
		// by SizeParamIndex and can't be changed.
		[Ignore("Not supported")]
		[Test]
		public void Array_Callback_InOut() {
			var rets = new int[2];
			var callbackCount = 0;

			TestCallbackArrayInOut cb = new TestCallbackArrayInOut(
				(ref int[] ints) => {
					var length = ints.Length;
					rets[callbackCount] = length;
					length--;
					callbackCount++;
					ints = new int[length];
					for (int i = 0; i < length; i++) {
						ints[i] = i - (2 - callbackCount);
					}
				}
			);

			var ret = TestArrayInoutCallback(cb);

			Assert.That(ret, Is.EqualTo(3));
			Assert.That(callbackCount, Is.EqualTo(2));
			Assert.That(rets[0], Is.EqualTo(5));
			Assert.That(rets[1], Is.EqualTo(4));
		}

		[Test]
		public void Array_FixedOut_Objects() {
			var res = TestArrayFixedOutObjects();
			Assert.Multiple(() => {
				Assert.That(res, Has.Length.EqualTo(2));
				Assert.That(res[0] is TestObj, Is.True);
				Assert.That(res[1] is TestObj, Is.True);
			});
		}

		[Test]
		public void Array_FixedSize_Int_In() {
			var ints = new int[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayFixedSizeIntIn(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_FixedSize_Int_Out() {
			var res = TestArrayFixedSizeIntOut();

			Assert.Multiple(() => {
				Assert.That(res, Has.Length.EqualTo(5));
				Assert.That(res[0], Is.EqualTo(0));
				Assert.That(res[1], Is.EqualTo(1));
				Assert.That(res[2], Is.EqualTo(2));
				Assert.That(res[3], Is.EqualTo(3));
				Assert.That(res[4], Is.EqualTo(4));
			});
		}

		[Test]
		public void Array_gint8_In() {
			var ints = new sbyte[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayGint8In(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_gint16_In() {
			var ints = new short[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayGint16In(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_gint32_In() {
			var ints = new int[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayGint32In(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_gint64_In() {
			var ints = new long[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayGint64In(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_GType_In() {
			var gTypes = new GLib.GType[3] { FooBoxed.GType, FooBuffer.GType, FooObject.GType };
			var res = TestArrayGtypeIn(gTypes);
			Assert.That(res, Is.EqualTo("[RegressFooBoxed,RegressFooBuffer,RegressFooObject,]"));
		}

		[Test]
		public void Array_int_In() {
			var ints = new int[5] { 0, 1, 2, 3, 4 };
			var res = TestArrayIntIn(ints);
			Assert.That(res, Is.EqualTo(1 + 2 + 3 + 4));
		}

		[Test]
		public void Array_int_Out() {
			var ints = TestArrayIntOut();
			Assert.That(ints, Is.EqualTo(new int[5] { 0, 1, 2, 3, 4 }));
		}

		[Test]
		public void Array_int_InOut() {
			var ints = new int[5] { 0, 1, 2, 3, 4 };
			TestArrayIntInout(ref ints);
			Assert.That(ints, Is.EqualTo(new int[4] { 2, 3, 4, 5 }));
		}

		[Test]
		public void Array_int_NullOut() {
			int[] arr = TestArrayIntNullOut();
			Assert.That(arr, Is.Null);
		}

		[Test]
		public void Array_Static_int_In() {
			var ints = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			TestArrayStaticInInt(ints);
		}

		[Ignore("FIXME: Transfer ful crash, copy needed")]
		[Test]
		public void Array_Struct_In_Full() {
			var structs = new TestStructA[2] {
				new TestStructA {SomeInt = 201},
				new TestStructA {SomeInt = 202}
			};
			TestArrayStructInFull(structs);
		}

		[Test]
		public void Array_Struct_In_None() {
			var structs = new TestStructA[3] {
				new TestStructA {SomeInt = 301},
				new TestStructA {SomeInt = 302},
				new TestStructA {SomeInt = 303},
			};
			TestArrayStructInNone(structs);
		}

		[Test]
		public void Array_Struct_Out() {
			TestStructA[] structs = TestArrayStructOut();
			Assert.Multiple(() => {
				Assert.That(structs, Has.Length.EqualTo(3));
				Assert.That(structs[0].SomeInt, Is.EqualTo(22));
				Assert.That(structs[1].SomeInt, Is.EqualTo(33));
				Assert.That(structs[2].SomeInt, Is.EqualTo(44));
			});
		}

		[Ignore("FIXME: caller-allocates not implemented")]
		[Test]
		public void Array_Struct_Out_CallerAlloc() {
			TestStructA[] structs = TestArrayStructOutCallerAlloc();
			Assert.Multiple(() => {
				Assert.That(structs, Has.Length.EqualTo(3));
				Assert.That(structs[0].SomeInt, Is.EqualTo(22));
				Assert.That(structs[1].SomeInt, Is.EqualTo(33));
				Assert.That(structs[2].SomeInt, Is.EqualTo(44));
			});
		}

		[Test]
		public void Array_Struct_Out_Container() {
			TestStructA[] structs = TestArrayStructOutContainer();
			Assert.Multiple(() => {
				Assert.That(structs, Has.Length.EqualTo(5));
				Assert.That(structs[0].SomeInt, Is.EqualTo(11));
				Assert.That(structs[1].SomeInt, Is.EqualTo(13));
				Assert.That(structs[2].SomeInt, Is.EqualTo(17));
				Assert.That(structs[3].SomeInt, Is.EqualTo(19));
				Assert.That(structs[4].SomeInt, Is.EqualTo(23));
			});
		}

		[Test]
		public void Array_Struct_Out_Full_Fixed() {
			var res = TestArrayStructOutFullFixed();

			Assert.Multiple(() => {
				Assert.That(res, Has.Length.EqualTo(4));
				Assert.That(res[0].SomeInt, Is.EqualTo(2));
				Assert.That(res[1].SomeInt, Is.EqualTo(3));
				Assert.That(res[2].SomeInt, Is.EqualTo(5));
				Assert.That(res[3].SomeInt, Is.EqualTo(7));
			});
		}

		[Ignore("FIXME: segfault, copy is needed with transfer none")]
		[Test]
		public void Array_Struct_Out_None() {
			TestStructA[] structs = TestArrayStructOutNone();
			Assert.That(structs, Has.Length.EqualTo(3));
			Assert.That(structs[0].SomeInt, Is.EqualTo(111));
			Assert.That(structs[1].SomeInt, Is.EqualTo(222));
			Assert.That(structs[2].SomeInt, Is.EqualTo(333));
		}
	}
}