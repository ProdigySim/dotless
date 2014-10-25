namespace dotless.Test.Specs.Functions
{
    using NUnit.Framework;

    public class UnitFixture : SpecFixtureBase
    {
        [Test]
        public void TestUnit()
        {
            AssertExpression("5px", "unit(5,px)");
            AssertExpression("5", "unit(5em)");
        }
    }
}