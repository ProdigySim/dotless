namespace dotless.Core.Parser.Functions
{
    using System;
    using System.Linq;
    using Infrastructure;
    using Infrastructure.Nodes;
    using Tree;
    using Utils;

    public class UnitFunction : Function
    {
        protected override Node Evaluate(Env env)
        {
            Guard.ExpectMinArguments(1, Arguments.Count, this, Location);
            Guard.ExpectMaxArguments(2, Arguments.Count, this, Location);
            Guard.ExpectNode<Number>(Arguments[0], this, Location);

            var first = (Number)Arguments.First();
            if (Arguments.Count == 1)
            {
                return new Number(first.Value);
            }
            else
            {
                Guard.ExpectNode<Keyword>(Arguments[1], this, Location);
                var second = (Keyword)Arguments.ElementAt(1);

                return new Number(first.Value, second.Value);
            }
        }
    }
}
