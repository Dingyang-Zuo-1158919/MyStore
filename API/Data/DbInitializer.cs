using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "masamune",
                    Email = "masamune@spitz.com"
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@spitz.com"
                };
                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Admin", "Member" });
            }

            if (context.Products.Any())
            {
                context.Products.RemoveRange(context.Products);
                context.SaveChanges();
            }

            var products = new List<Product>
            {
                new Product
                {
                    Name = "ひみつスタジオ",
                    Description = "Secret Studio",
                    Price = 2023,
                    PictureUrl = "/images/ひみつスタジオ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "見っけ",
                    Description = "Found it",
                    Price = 2019,
                    PictureUrl = "/images/見っけ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "醒めない",
                    Description = "Not Wake Up",
                    Price = 2016,
                    PictureUrl = "/images/醒めない.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "小さな生き物",
                    Description = "Little Creatures",
                    Price = 2013,
                    PictureUrl = "/images/小さな生き物.jpg",
                    Brand = "Spitz",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "おるたな",
                    Description = "Orutana",
                    Price = 2012,
                    PictureUrl = "/images/おるたな.jpg",
                    Brand = "スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "とげまる",
                    Description = "Spiky Ball",
                    Price = 2010,
                    PictureUrl = "/images/とげまる.jpg",
                    Brand = "Spitz",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "さざなみ CD",
                    Description = "Rippl CD",
                    Price = 2007,
                    PictureUrl = "/images/さざなみ CD.jpg",
                    Brand = "スピッツ",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "スーベニア",
                    Description = "Souvenir",
                    Price = 2005,
                    PictureUrl = "/images/スーベニア.jpg",
                    Brand = "Spitz",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "色色衣",
                    Description = "Various Clothes",
                    Price = 2004,
                    PictureUrl = "/images/色色衣.jpg",
                    Brand = "スピッツ",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "三日月ロック",
                    Description = "Crescent Rock",
                    Price = 2002,
                    PictureUrl = "/images/三日月ロック.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "ハヤブサ",
                    Description = "Falcon",
                    Price = 2000,
                    PictureUrl = "/images/ハヤブサ.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "花鳥風月",
                    Description = "Beauty of Nature",
                    Price = 1999,
                    PictureUrl = "/images/花鳥風月.jpg",
                    Brand = "Spitz",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "フェイクファー",
                    Description = "Fake Fur",
                    Price = 1998,
                    PictureUrl = "/images/フェイクファー.jpg",
                    Brand = "スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "インディゴ地平線",
                    Description = "Indigo Horizon",
                    Price = 1996,
                    PictureUrl = "/images/インディゴ地平線.jpg",
                    Brand = "スピッツ",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "ハチミツ",
                    Description = "Honey",
                    Price = 1995,
                    PictureUrl = "/images/ハチミツ.jpg",
                    Brand = "Spitz",
                    Type = "Japan Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "空の飛び方",
                    Description = "How to Fly in the Sky",
                    Price = 1994,
                    PictureUrl = "/images/空の飛び方.jpg",
                    Brand = "Spitz/スピッツ",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Crispy!",
                    Description = "Crispy!",
                    Price = 1993,
                    PictureUrl = "/images/Crispy!.jpg",
                    Brand = "スピッツ",
                    Type = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "惑星のかけら",
                    Description = "Piece of the Planet",
                    Price = 1992,
                    PictureUrl = "/images/惑星のかけら.jpg",
                    Brand = "Spitz",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "名前をつけてやる",
                    Description = "I'll Give You a Name",
                    Price = 1991,
                    PictureUrl = "/images/名前をつけてやる.jpg",
                    Brand = "スピッツ",
                    Type = "Japan",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "スピッツ",
                    Description = "Spitz",
                    Price = 1991,
                    PictureUrl = "/images/スピッツ.jpg",
                    Brand = "Spitz",
                    Type = "Rock",
                    QuantityInStock = 100
                },
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}