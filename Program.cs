using System;

namespace Inventory_System_Pro
{
    internal class Program
    {

        private const int maxProducts = 50;
        private static string[,] Inventory = new string [maxProducts, 3];
        private static int productCounter = 0;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Welcome To inventory system");
                Console.WriteLine("=================================");
                Console.WriteLine("Please Choose ->");
                Console.WriteLine("(1) Add Product");
                Console.WriteLine("(2) View Product");
                Console.WriteLine("(3) Ubdate Product");
                Console.WriteLine("(4) Exit");

                string userinput = Console.ReadLine();
                switch (userinput)
                {
                   
                    case "1":
                        // Add Product
                        AddProduct();
                        break;
                    case "2":
                        // View Product
                        viewProduct();
                        break;
                    case "3":
                        // Ubdate Product
                        ubdateProduct();
                        break;
                    case "4":
                        // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
           

        }

        static void AddProduct()
        {
            Console.WriteLine("Enter The Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price");
            string price  = Console.ReadLine();

            Console.WriteLine("Enter the product Quantity");
            string quantity = Console.ReadLine();

            Inventory[productCounter, 0] = name;
            Inventory[productCounter, 1] = price;
            Inventory[productCounter, 2] = quantity;

            productCounter++;
            Console.WriteLine("---Done---");
        }

        static void viewProduct()
        {
            if(productCounter > 0)
            {
                for (int i = 0; i < productCounter; i++)
                {
                    Console.WriteLine($"{i + 1} - Product Name -> {Inventory[i, 0]}, Product Price -> {Inventory[i, 1]}, The product Quantity -> {Inventory[i, 2]}");
                }
            }
            else
            {
                Console.WriteLine("There is no products to View");
            }
           
        }

        static void ubdateProduct()
        {
            Console.WriteLine("Enter the product name");
            string productname = Console.ReadLine();

            int productIndex = -1;
            if(productCounter > 0)
            {
                for (int i = 0; i < productCounter; i++)
                {
                    if (Inventory[i, 0] == productname)
                    {
                        productIndex = i;
                        break;
                    }
                }

                if (productIndex == -1)
                    Console.WriteLine("Doesnt Exist");

                if (productIndex != -1)
                {
                    Console.WriteLine("(1) Change Product Name ");
                    Console.WriteLine("(2) Change Product Price ");
                    Console.WriteLine("(3) Change Product Quantity ");
                    Console.WriteLine("(4) change All");

                    string newuserinput = Console.ReadLine();
                    switch (newuserinput)
                    {
                        case "1":
                            Ubdatename(productIndex);
                            break;
                        case "2":
                            Ubdateprice(productIndex);
                            break;
                        case "3":
                            Ubdatequantity(productIndex);
                            break;
                        case "4":
                            Ubdatename(productIndex);
                            Ubdateprice(productIndex);
                            Ubdatequantity(productIndex);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
         


            }
            else
            {
                Console.WriteLine("There is no Products To Ubdate");
            }


        }

        static void Ubdatename(int index)
        {
            Console.WriteLine("Enter the New Name");
            string name = Console.ReadLine();

            Inventory[index, 0] = name;

            Console.WriteLine("---Done---");
        }

        static void Ubdateprice(int index)
        {
            Console.WriteLine("Enter the New Price");
            string price = Console.ReadLine();

            Inventory[index, 1] = price;

            Console.WriteLine("---Done---");


        }

        static void Ubdatequantity(int index)
        {
            Console.WriteLine("Enter the New Quantity");
            string quantity = Console.ReadLine();

            Inventory[index, 2] = quantity;

            Console.WriteLine("---Done---");


        }




    }
}
