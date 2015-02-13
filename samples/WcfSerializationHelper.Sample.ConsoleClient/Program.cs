using System;
using WcfSerializationHelper.Sample.ConsoleClient.SampleService;

namespace WcfSerializationHelper.Sample.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new SampleServiceClient())
            {
                Console.WriteLine("Press Enter to get categories");
                Console.ReadLine();
                var categories = client.GetCategories();
                foreach (var c in categories)
                {
                    Console.WriteLine("{0} {1}",
                        c.CategoryId, c.CategoryName);
                }

                Console.WriteLine("\nPress Enter to get products");
                Console.ReadLine();
                var products = client.GetProducts();
                foreach (var p in products)
                {
                    Console.WriteLine("{0} {1}",
                        p.ProductId, p.ProductName);
                }
            }
        }
    }
}
