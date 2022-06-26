using lab4_patterns2.Decorators;
using lab4_patterns2.Models;
using System;
namespace Lab4_StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseBouquet roses = new RoseBouquet() { Amount = 11, Price = 35};
            roses = new RibbonsDecorator(roses) { Color = "Yellow"};
            Console.WriteLine($"Bouquet of: {roses.GetBouquetComposition()}, Price: {roses.CalculatePrice()}");

            BaseBouquet camomiles = new CamomileBouquet() { Amount = 17, Price = 22 };
            camomiles = new RibbonsDecorator(camomiles) { Color = "Red" };
            camomiles = new FernDecorator(camomiles);
            Console.WriteLine($"Bouquet of: {camomiles.GetBouquetComposition()}, Price: {camomiles.CalculatePrice()}");

            BaseBouquet chrysanthemums = new ChrysanthemumBouquet() { Amount = 7, Price = 18 };
            chrysanthemums = new RibbonsDecorator(chrysanthemums) { Color = "Bordo" };
            chrysanthemums = new FernDecorator(chrysanthemums);
            chrysanthemums = new PostcardDecorator(chrysanthemums, "Some postcard message!");
            Console.WriteLine($"Bouquet of: {chrysanthemums.GetBouquetComposition()}, Price: {chrysanthemums.CalculatePrice()}");

        }
    }
}

