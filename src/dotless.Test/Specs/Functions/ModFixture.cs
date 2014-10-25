namespace dotless.Test.Specs.Functions
{
    using NUnit.Framework;

    public class ModFixture : SpecFixtureBase
    {
        [Test]
        public void TestMod()
        {
            AssertExpression("2", "mod(2, 3)");
            AssertExpression("1", "mod(3, 2)");

            AssertExpression("NaNcm", "mod(0cm, 0px)");
            AssertExpression("5cm", "mod(11cm, 6px)");
            AssertExpression("-1%", "mod(-26%, -5)");
        }
    }
}
