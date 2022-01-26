using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace onlineshoppingstore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ShoppingStoreEntities>
    {
        protected override void Seed(ShoppingStoreEntities context)
        {


            var categories = new List<Category>
            {
                new Category { Name = "Sweater" },
                new Category { Name = "Dress" },
                new Category { Name = " Hoodies "},
                new Category { Name = "T-shirt"} ,
                new Category { Name = "Jacket" },
                new Category { Name = "Shorts" },
                new Category { Name = "Jeans" },
                new Category { Name = "Coat" },
                new Category { Name = "Suit" }
            };

            var producers = new List<Producer>
            {
                new Producer { Name = "Beats" },
                new Producer { Name = "Ray Ban" },
                new Producer { Name = "Ikea" },
                new Producer { Name = "Cannon" },
                new Producer { Name = "Philips" },
                new Producer { Name = "Precor" },
                new Producer { Name = "Local Dist" },

                new Producer { Name = "Zara" },
                new Producer { Name = "Apple" },
                new Producer { Name = "Brawn" },
                new Producer { Name = "Zeca Pagodinho" }
            };

            new List<Item>
            {
                new Item { Title = "Sweater", Category = categories.Single(g => g.Name == "Sweater"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Beats"), ItemArtUrl = "/Content/Images/sweater.jpg" },
                new Item { Title = "Dress", Category = categories.Single(g => g.Name == "Dress"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ray Ban"), ItemArtUrl = "/Content/Images/dress.jpg" },
                new Item { Title = "Hoodies", Category = categories.Single(g => g.Name == "Hoodies"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ikea"), ItemArtUrl = "/Content/Images/hoodie.jpg" },
                new Item { Title = "T-shirt", Category = categories.Single(g => g.Name == "T-shirt"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ikea"), ItemArtUrl = "/Content/Images/tshirt.jpg" },
                new Item { Title = "Jacket", Category = categories.Single(g => g.Name == "Jacket"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Cannon"), ItemArtUrl = "/Content/Images/jacket.jpg" },
                new Item { Title = "Shorts", Category = categories.Single(g => g.Name == "Shorts"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Philips"), ItemArtUrl = "/Content/Images/shorts.jpg" },
                new Item { Title = "Jeans", Category = categories.Single(g => g.Name == "Jeans"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Local Dist"), ItemArtUrl = "/Content/Images/jeans.jpg" },
                new Item { Title = "Coat", Category = categories.Single(g => g.Name == "Coat"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Zara"), ItemArtUrl = "/Content/Images/coat.jpg" },
                new Item { Title = "Suit", Category = categories.Single(g => g.Name == "Suit"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Precor"), ItemArtUrl = "/Content/Images/suits.jpg" },
                new Item { Title = "Jeans", Category = categories.Single(g => g.Name == "Jeans"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Apple"), ItemArtUrl = "/Content/Images/jeans1.jpg" },
                new Item { Title = "Suit", Category = categories.Single(g => g.Name == "Suit"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Brawn"), ItemArtUrl = "/Content/Images/suit.png" },
                new Item { Title = "Dress", Category = categories.Single(g => g.Name == "Dress"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Local distr"), ItemArtUrl = "/Content/Images/dress.jpg" },

            }.ForEach(a => context.Items.Add(a));
        }
    }
}