namespace dotless.Test.Specs.Functions
{
    using NUnit.Framework;

    public class LumaFixture : SpecFixtureBase
    {
        [Test]
        public void TestLuma()
        {
            
            AssertExpression("100%", "luma(#fff)");
            AssertExpression("0%", "luma(#000)");
            AssertExpression("0%", "luma(rgba(0,0,0,0.5))");
            AssertExpression("21.26%", "luma(#ff0000)");
            AssertExpression("71.52%", "luma(#00ff00)");
            AssertExpression("7.22%", "luma(#0000ff)");
            AssertExpression("92.78%", "luma(#ffff00)");
            AssertExpression("78.74%", "luma(#00ffff)");
            AssertExpression("23.898333493%", "luma(#ff3600)");
        }

        [Test]
        public void TestLuminance()
        {
            AssertExpression("100%", "luminance(#fff)");
            AssertExpression("0%", "luminance(#000)");
            AssertExpression("0%", "luminance(rgba(0,0,0,0.5))");
            AssertExpression("21.26%", "luminance(#ff0000)");
            AssertExpression("36.405411765%", "luminance(#ff3600)");
        }

        [Test]
        public void TestLumaLuminanceTestsTypes()
        {
            AssertExpressionError("Expected color in function 'luma', found \"foo\"", 5, "luma(\"foo\")");
            AssertExpressionError("Expected color in function 'luminance', found \"foo\"", 10, "luminance(\"foo\")");
        }
    }
}