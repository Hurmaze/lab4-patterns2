using lab4_patterns2.Models;
using System;
namespace lab4_patterns2.Decorators
{
    public class PostcardDecorator : Decorator
    {
        private string message;
        public PostcardDecorator(BaseBouquet bouquet, string PostcardText) : base(bouquet)
        {
            message = PostcardText;
        }

        public override string GetBouquetComposition()
        {
            return base.GetBouquetComposition() + $" with Postcard: {message} ";
        }


    }
}

