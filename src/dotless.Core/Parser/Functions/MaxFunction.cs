namespace dotless.Core.Parser.Functions
{
    using System;
    using System.Linq;
    using Infrastructure;
    using Infrastructure.Nodes;
    using Tree;
    using Utils;
    using dotless.Core.Exceptions;

    public class MaxFunction : Function
    {
        protected override Node Evaluate(Env env)
        {
            Guard.ExpectMinArguments(1, Arguments.Count, this, Location);
            Guard.ExpectAllNodes<Number>(Arguments, this, Location);

            var numbers = Arguments.Cast<Number>();
            var max = numbers.First();

            foreach (var num in numbers.Skip(1))
            {
                if (num.Unit != max.Unit)
                {
                    throw new ParsingException(string.Format("Unit types of max function arguments don't match. {0} doesn't match unit {1}", num.ToCSS(env), max.Unit), num.Location);
                }
                if (num.Value > max.Value)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}
