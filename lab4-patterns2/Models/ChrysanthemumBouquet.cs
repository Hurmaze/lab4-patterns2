using System;
namespace lab4_patterns2.Models
{
    public class ChrysanthemumBouquet : BaseBouquet
    {
        public override string GetBouquetComposition()
        {
            return $"{Amount} of Chrysanthemum ";
        }
    }
}

