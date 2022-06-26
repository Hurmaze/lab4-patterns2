using System;
namespace lab4_patterns2.Models
{
    public class CamomileBouquet : BaseBouquet
    {
        public override string GetBouquetComposition()
        {
            return $"{Amount} of Camomile ";
        }
    }
}

