using lab4_patterns2.Models;
using System;
namespace lab4_patterns2.Decorators
{
    public abstract class Decorator : BaseBouquet
    {
        protected readonly BaseBouquet _bouquet;
        protected Decorator(BaseBouquet bouquet)
        {
            _bouquet = bouquet;
        }

        public override string GetBouquetComposition()
        {
            return _bouquet.GetBouquetComposition();
        }

        public override decimal CalculatePrice()
        {
            return _bouquet.CalculatePrice() + Price;
        }

    }
}

