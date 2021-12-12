using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data {

  public static class DBInitializer {

    public static void Initialize(StoreContext context) {
      
      if (context.Products.Any()) return;
      List<Product> products = new List<Product> {

        new Product {
          Name = "Adidas White",
          Description = "White adidas Running Shoes",
          Price = 2000,
          PictureUrl = "/images/products/adidas2.jpg",
          Brand = "Adidas",
          Type = "Sneakers",
          QuantityInStock = 100
        },
        new Product {
          Name = "Adidas Red",
          Description = "Red Adidas Running Shoes",
          Price = 3000,
          PictureUrl = "/images/products/adidas3.jpg",
          Brand = "Adidas",
          Type = "Sneakers",
          QuantityInStock = 100
        },
        new Product {
          Name = "Adidas Black",
          Description = "Black Adidas running shoes",
          Price = 2000,
          PictureUrl = "/images/products/adidas1.jpg",
          Brand = "Adidas",
          Type = "Sneakers",
          QuantityInStock = 100
        },
        new Product {
          Name = "Nike Hoodie",
          Description = "Blue Nike Hoodie",
          Price = 2000,
          PictureUrl = "/images/products/nikeHoodie.jpg",
          Brand = "Nike",
          Type = "Hoodie",
          QuantityInStock = 15
        },
        new Product {
          Name = "Grey Hoodie",
          Description = "Under Armour Grey Hoodie",
          Price = 2000,
          PictureUrl = "/images/products/underarmour.jpeg",
          Brand = "Underarmour",
          Type = "Hoodie",
          QuantityInStock = 100
        },
        new Product {
          Name = "Oaxaca Coffee",
          Description = "Oaxaca Artesanal Coffee ",
          Price = 30,
          PictureUrl = "/images/products/coffeeOaxaca.jpg",
          Brand = "XO",
          Type = "Coffee",
          QuantityInStock = 100
        },
        new Product {
          Name = "PRS Custom 24 Blue Whale",
          Description = "Unique Jass/Rock Guitar with AA spruce blue maple top",
          Price = 3000,
          PictureUrl = "/images/products/prs4.jpg",
          Brand = "PRS",
          Type = "Guitar",
          QuantityInStock = 42
        },
        new Product {
          Name = "PRS Custome 24 Honey Mample",
          Description = "Unique Jass/Rock Guitar with AA spruce honey maple top",
          Price = 2000,
          PictureUrl = "/images/products/prshoney.jpeg",
          Brand = "PRS",
          Type = "Guitar",
          QuantityInStock = 100
        },
        new Product {
          Name = "Blade Razer 15 Advanced",
          Description = "Razer laptop for gaming or development",
          Price = 2000,
          PictureUrl = "/images/products/razer_blade.jpg",
          Brand = "Razer",
          Type = "Laptop",
          QuantityInStock = 15
        },
        new Product {
          Name = "Cristiano Ronaldo",
          Description = "Manchester United T - Shirt with no. 7",
          Price = 120,
          PictureUrl = "/images/products/ronaldo_shirt.png",
          Brand = "Adidas",
          Type = "Shirt",
          QuantityInStock = 100
        },

      };

      foreach(var product in products) {
        context.Products.Add(product);
      }

      context.SaveChanges();

    }

  }

}