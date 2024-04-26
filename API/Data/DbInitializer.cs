using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "ひみつスタジオ",
                    Description = "Secret Studio",
                    Price = 2023,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "見っけ",
                    Description = "I found",
                    Price = 2019,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "醒めない",
                    Description = "Can't Wake Up",
                    Price = 2016,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "小さな生き物",
                    Description = "Small Creature",
                    Price = 2013,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "とげまる",
                    Description = "Spiky Ball",
                    Price = 2010,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "さざなみ",
                    Description = "Ripple",
                    Price = 2007,
                    PictureUrl = "",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}