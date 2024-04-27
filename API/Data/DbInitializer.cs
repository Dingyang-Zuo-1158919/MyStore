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
                    PictureUrl = "client/public/images/ひみつスタジオ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "見っけ",
                    Description = "Found it",
                    Price = 2019,
                    PictureUrl = "client/public/images/見っけ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "醒めない",
                    Description = "Not Wake Up",
                    Price = 2016,
                    PictureUrl = "client/public/images/醒めない.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "小さな生き物",
                    Description = "Little Creatures",
                    Price = 2013,
                    PictureUrl = "client/public/images/小さな生き物.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "おるたな",
                    Description = "Orutana",
                    Price = 2012,
                    PictureUrl = "client/public/images/おるたな.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "とげまる",
                    Description = "Spiky Ball",
                    Price = 2010,
                    PictureUrl = "client/public/images/とげまる.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "さざなみ CD",
                    Description = "Rippl CD",
                    Price = 2007,
                    PictureUrl = "client/public/images/さざなみ CD.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "スーベニア",
                    Description = "Souvenir",
                    Price = 2005,
                    PictureUrl = "client/public/images/スーベニア.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "色色衣",
                    Description = "Various Clothes",
                    Price = 2004,
                    PictureUrl = "client/public/images/色色衣.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "三日月ロック",
                    Description = "Crescent Rock",
                    Price = 2002,
                    PictureUrl = "client/public/images/三日月ロック.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "ハヤブサ",
                    Description = "Falcon",
                    Price = 2000,
                    PictureUrl = "client/public/images/ハヤブサ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "花鳥風月",
                    Description = "Beauty of Nature",
                    Price = 1999,
                    PictureUrl = "client/public/images/花鳥風月.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "フェイクファー",
                    Description = "Fake Fur",
                    Price = 1998,
                    PictureUrl = "client/public/images/フェイクファー.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "インディゴ地平線",
                    Description = "Indigo Horizon",
                    Price = 1996,
                    PictureUrl = "client/public/images/インディゴ地平線.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "ハチミツ",
                    Description = "Honey",
                    Price = 1995,
                    PictureUrl = "client/public/images/ハチミツ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "空の飛び方",
                    Description = "How to Fly in the Sky",
                    Price = 1994,
                    PictureUrl = "client/public/images/空の飛び方.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Crispy!",
                    Description = "Crispy!",
                    Price = 1993,
                    PictureUrl = "client/public/images/Crispy!.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "惑星のかけら",
                    Description = "Piece of the Planet",
                    Price = 1992,
                    PictureUrl = "client/public/images/惑星のかけら.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "名前をつけてやる",
                    Description = "I'll Give You a Name",
                    Price = 1991,
                    PictureUrl = "client/public/images/名前をつけてやる.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "スピッツ",
                    Description = "Spitz",
                    Price = 1991,
                    PictureUrl = "client/public/images/スピッツ.jpg",
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