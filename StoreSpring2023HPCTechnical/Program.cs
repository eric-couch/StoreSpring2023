using StoreSpring2023HPCTechnical.Data;
using StoreSpring2023HPCTechnical.Models;

using StoreContext context = new StoreContext();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;
foreach (var product in products)
{
    Console.WriteLine($"Id:\t{product.Id}\nName:\t{product.Name}\nPrice:\t{product.Price}");
}
