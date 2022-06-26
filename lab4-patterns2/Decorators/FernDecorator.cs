using lab4_patterns2.Models;
using System;
namespace lab4_patterns2.Decorators
{ 
    public sealed class FernDecorator : Decorator
    {
        public FernDecorator(BaseBouquet bouquet) : base(bouquet)
        {
        }

        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with Fern ";
        }
    }
}

