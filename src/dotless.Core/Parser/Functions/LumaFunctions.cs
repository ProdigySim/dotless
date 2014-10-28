namespace dotless.Core.Parser.Functions
{
    using System.Linq;
    using Infrastructure.Nodes;
    using Tree;

    public class LumaFunction : ColorFunctionBase
    {
        protected override Node Eval(Color color)
        {
            return new Number(color.Luma * color.Alpha * 100, "%");
        }
    }

    public class LuminanceFunction : ColorFunctionBase
    {
        protected override Node Eval(Color color)
        {

            return new Number(color.Luminance * color.Alpha * 100, "%");
        }
    }
}