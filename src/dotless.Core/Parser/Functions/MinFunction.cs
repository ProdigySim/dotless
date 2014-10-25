namespace dotless.Core.Parser.Functions
{
    using System;
    using System.Linq;
    using Infrastructure;
    using Infrastructure.Nodes;
    using Tree;
    using Utils;
    using dotless.Core.Exceptions;

    public class MinFunction : Function
    {
        protected override Node Evaluate(Env env)
        {
            Guard.ExpectMinArguments(1, Arguments.Count, this, Location);
            Guard.ExpectAllNodes<Number>(Arguments, this, Location);

            var numbers = Arguments.Cast<Number>();
            var min = numbers.First();

            foreach (var num in numbers.Skip(1))
            {
                if (num.Unit != min.Unit)
                {
                    throw new ParsingException(string.Format("Unit types of min function arguments don't match. {0} doesn't match unit {1}", num.ToCSS(env), min.Unit), num.Location);
                }
                if (num.Value < min.Value)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
