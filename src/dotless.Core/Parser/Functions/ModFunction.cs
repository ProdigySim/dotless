namespace dotless.Core.Parser.Functions
{
    using System;
    using System.Linq;
    using Infrastructure;
    using Infrastructure.Nodes;
    using Tree;
    using Utils;

    public class ModFunction : Function
    {
        protected override Node Evaluate(Env env)
        {
            Guard.ExpectMinArguments(2, Arguments.Count, this, Location);
            Guard.ExpectMaxArguments(2, Arguments.Count, this, Location);
            Guard.ExpectAllNodes<Number>(Arguments, this, Location);

            var first = Arguments.Cast<Number>().First();
            var second = Arguments.Cast<Number>().ElementAt(1);
            var value = first.Value % second.Value;

            return new Number(value, first.Unit);
        }
    }
}
