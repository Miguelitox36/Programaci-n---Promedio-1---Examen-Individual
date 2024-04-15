using System;
using System.Collections.Generic;


namespace Examen_Individual

{
    class Program
    {
        static void Main(string[] args)
        {
            CraftsStore store = new CraftsStore();

            
            ProductFabric productfabric1 = new ProductFabric("Shirt", 10.99f, "L", "Cotton", "Blue");
            ProductFabric productfabric2 = new ProductFabric("Pants", 15.99f, "M", "Wool", "Black");
            ProductClay productclay1 = new ProductClay("Flowerpot", 20.99f, "Small", "Red", 1.5f);
            ProductClay productclay2 = new ProductClay("Vase", 30.99f, "Big", "White", 2.8f);

           
            store.AddProduct(productfabric1);
            store.AddProduct(productfabric2);
            store.AddProduct(productclay1);
            store.AddProduct(productclay2);


            Console.WriteLine("Welcome to the Craft Store");
            Console.WriteLine("Enter '1' to add products to cart");
            Console.WriteLine("Enter '2' to view cart contents");
            Console.WriteLine("Enter '3' to checkout");

            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    Console.WriteLine("Select the number of the product you want to add to the cart:");
                    Console.WriteLine("1. Scarf");
                    Console.WriteLine("2. Hat");
                    Console.WriteLine("3. Flowerpot");
                    Console.WriteLine("4. Vase");

                    string opcionProducto = Console.ReadLine();
                    switch (opcionProducto)
                    {
                        case "1":
                            store.AddProduct(productfabric1);
                            Console.WriteLine("Scarf added to cart.");
                            break;
                        case "2":
                            store.AddProduct(productfabric2);
                            Console.WriteLine("Hat added to cart.");
                            break;
                        case "3":
                            store.AddProduct(productclay1);
                            Console.WriteLine("Flowerpot added to cart.");
                            break;
                        case "4":
                            store.AddProduct(productclay2);
                            Console.WriteLine("Vase added to cart.");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                        }
                    break;
                case "2":
                    store.showCartContents();
                    break;
                case "3":
                    Console.WriteLine("¿Are you sure you want to complete the purchase? (Y/N)");
                    string confirmacion = Console.ReadLine();
                    if (confirmacion.ToUpper() == "S")
                    {
                        Console.WriteLine("Purchase completed.");
                    }
                    else
                    {
                        Console.WriteLine("Purchase canceled.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}