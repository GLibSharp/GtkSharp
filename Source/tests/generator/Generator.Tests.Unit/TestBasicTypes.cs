using static Regress.Global;

namespace Generator.Tests {
	[TestFixture]
	public class TestBasicTypes {
		[Test]
		[TestCase(true)]
		[TestCase(false)]
		public void BasicTypes_boolean(bool val) {
			Assert.That(TestBoolean(val), Is.EqualTo(val));
		}

		[Test]
		public void BasicTypes_boolean_false() {
			Assert.That(TestBooleanFalse(false), Is.False);
		}

		[Test]
		public void BasicTypes_boolean_true() {
			Assert.That(TestBooleanTrue(true), Is.True);
		}

		[Test]
		[TestCase(short.MaxValue)]
		[TestCase(short.MinValue)]
		public void BasicTypes_short(short val) {
			Assert.That(TestShort(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(ushort.MaxValue)]
		[TestCase(ushort.MinValue)]
		public void BasicTypes_ushort(ushort val) {
			Assert.That(TestUshort(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(long.MaxValue)]
		[TestCase(long.MinValue)]
		public void BasicTypes_long(long val) {
			Assert.That(TestLong(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(ulong.MaxValue)]
		[TestCase(ulong.MinValue)]
		public void BasicTypes_ulong(ulong val) {
			Assert.That(TestUlong(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(double.MaxValue)]
		[TestCase(double.MinValue)]
		public void BasicTypes_double(double val) {
			Assert.That(TestDouble(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(float.MaxValue)]
		[TestCase(float.MinValue)]
		public void BasicTypes_float(float val) {
			Assert.That(TestFloat(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(int.MaxValue)]
		[TestCase(int.MinValue)]
		public void BasicTypes_int(int val) {
			Assert.That(TestInt(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(sbyte.MaxValue)]
		[TestCase(sbyte.MinValue)]
		public void BasicTypes_int8(sbyte val) {
			Assert.That(TestInt8(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(short.MaxValue)]
		[TestCase(short.MinValue)]
		public void BasicTypes_int16(short val) {
			Assert.That(TestInt16(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(int.MaxValue)]
		[TestCase(int.MinValue)]
		public void BasicTypes_int32(int val) {
			Assert.That(TestInt32(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(long.MaxValue)]
		[TestCase(long.MinValue)]
		public void BasicTypes_int64(long val) {
			Assert.That(TestInt64(val), Is.EqualTo(val));
		}


		[Test]
		[TestCase(uint.MaxValue)]
		[TestCase(uint.MinValue)]
		public void BasicTypes_uint(uint val) {
			Assert.That(TestUint(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(byte.MaxValue)]
		[TestCase(byte.MinValue)]
		public void BasicTypes_uint8(byte val) {
			Assert.That(TestUint8(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(ushort.MaxValue)]
		[TestCase(ushort.MinValue)]
		public void BasicTypes_uint16(ushort val) {
			Assert.That(TestUint16(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(uint.MaxValue)]
		[TestCase(uint.MinValue)]
		public void BasicTypes_uint32(uint val) {
			Assert.That(TestUint32(val), Is.EqualTo(val));
		}

		[Test]
		[TestCase(ulong.MaxValue)]
		[TestCase(ulong.MinValue)]
		public void BasicTypes_uint64(ulong val) {
			Assert.That(TestUint64(val), Is.EqualTo(val));
		}

		[Test]
		public void BasicTypes_unichar() {
			Assert.That(TestUnichar('a'), Is.EqualTo('a'));
		}
	}
}