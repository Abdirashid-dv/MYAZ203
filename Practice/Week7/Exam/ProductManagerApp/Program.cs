
using ProductManagerApp.Models;

ProductManager productManager = new ProductManager();
FoodProduct foodProduct = new FoodProduct(1, "Milk", 2.99, DateTime.Now.AddYears(1), true, 4.0);

productManager.add(foodProduct);

System.Console.WriteLine(productManager.getCount());