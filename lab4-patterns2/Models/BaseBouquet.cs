using System;
namespace lab4_patterns2.Models
{
    public abstract class BaseBouquet
    {
        public int Amount { get; internal set; }
        public decimal Price { get; internal set; }
        public abstract string GetBouquetComposition();

        public virtual decimal CalculatePrice()
        {
            return Price * Amount;
        }

    }
}

