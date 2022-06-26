using lab4_patterns2.Models;
using System;
namespace lab4_patterns2.Decorators
{
    /// <summary>
    /// Concrete decorator. Adds the ribbon with particular color to existing bouquet
    /// </summary>
    public class RibbonsDecorator : Decorator
    {
        public string Color { get; set; }
        public RibbonsDecorator(BaseBouquet bouquet) : base(bouquet)
        {

        }
        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with {Color} ribbon ";
        }
    }
}

