#if XUNIT
using System;

namespace SimpleSpeedTester.Tests
{
    public class ApplicationException : Exception { } // just doesn't exist
}
namespace NUnit.Framework
{
    public class TestFixtureAttribute : Attribute { }

    public class TestAttribute : Xunit.FactAttribute { }

    // note: this doesn't *work*; it requires code changes
    public class ExpectedExceptionAttribute : Attribute {
        public ExpectedExceptionAttribute(Type type) { }
    }
    static class Assert
    {
        public static void IsTrue(bool condition)
        {
            Xunit.Assert.True(condition);
        }
        public static void AreEqual<T>(T x, T y)
        {
            Xunit.Assert.Equal<T>(x, y);
        }
        public static void IsNull(object @object)
        {
            Xunit.Assert.Null(@object);
        }
        public static void IsNotNull(object @object)
        {
            Xunit.Assert.NotNull(@object);
        }
        public static void IsInstanceOf(Type type, object @object)
        {
            Xunit.Assert.IsType(type, @object);
        }
    }
}
#endif