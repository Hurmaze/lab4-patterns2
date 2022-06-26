using lab4_patterns2.Models;
using System;
namespace lab4_patterns2.Decorators
{
    public class RibbonsDecorator : Decorator
    {
        public string Color { get; set; }
        public RibbonsDecorator(BaseBouquet bouquet, string color) : base(bouquet)
        {
            Color = color;
        }
        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with {Color} ribbon ";
        }
    }
}

