using System;
namespace lab4_patterns2.Models
{
    public class RoseBouquet : BaseBouquet
    {
        public override string GetBouquetComposition()
        {
            return $"{Amount} of Rose ";
        }
    }
}

