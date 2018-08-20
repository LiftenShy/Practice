using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Event_Delegate
{
    class Program
    {
        public delegate void ShowProducts(List<IProduct> products);

        private string s = "s";

        static void Main(string[] args)
        {
            ShowProducts sp = SaveProductsInFile;

            sp += SaveProductsInXml;
            Publisher pub = new Publisher();

            Client client1 = new Client("client1", pub);
            Client client2 = new Client("client2", pub);

            Storage storage = new Storage();

            IProduct cup = new Cup
            {
                Name = "CupNeil",
                Type = "Cup",
                Cost = 3.15m,
                Color = Color.Aqua
            };

            IProduct bike = new Bike
            {
                Name = "Stels",
                Type = "Bike",
                Cost = 315.48m,
                Height = 1.47,
                Weight = 14,
                Length = 1.3
            };

            storage.Products.Add(cup);
            pub.AddNewProduct(cup);
            storage.Products.Add(bike);
            pub.AddNewProduct(bike);

            int countCup = storage.SeacrhByType("Cup");

            sp(storage.Products);

            Console.ReadKey();
        }

        public static void SaveProductsInXml(IList<IProduct> products)
        {
            //code
        }

        public static void SaveProductsInFile(IList<IProduct> products)
        {
            try
            {


                string path = Path.GetFullPath(@"./products.txt");
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (var product in products)
                    {
                        sw.WriteLine($"{product} + \n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
