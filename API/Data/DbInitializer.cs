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
          PictureUrl = "/images/products/adidas2.jpg",
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
          PictureUrl = "/images/products/uderarmour.jpeg",
          Brand = "Underarmour",
          Type = "Hoodie",
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