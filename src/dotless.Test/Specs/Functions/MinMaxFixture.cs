namespace dotless.Test.Specs.Functions
{
    using NUnit.Framework;

    public class MinMaxFixture : SpecFixtureBase
    {
        [Test]
        public void TestMax()
        {
            AssertExpression("2", "max(2, 1)");
            AssertExpression("0.5", "max(-10.13, 0.5)");
            AssertExpression("42%", "max(3%, 42%, 1%, 16%)");
        }
        [Test]
        public void TestMin()
        {
            AssertExpression("1", "min(2, 1)");
            AssertExpression("-10.5", "min(-10.5, 0.5)");
            AssertExpression("1px", "min(3px, 42px, 1px, 16px)");
        }
    }
}
