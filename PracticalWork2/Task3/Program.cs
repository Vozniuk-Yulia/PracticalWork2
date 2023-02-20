using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\knute\oop\laboratory8\PracticalWork2\Task3\listofproduct.txt";
            List<Product> products = new List<Product>();
            List<string> temp = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                temp.AddRange(str.Split(' '));
                products.Add(new Product
                {
                    Name = temp[0],
                    Price = Convert.ToInt32(temp[1]),
                    Category = temp[2],
                });
                temp.Clear();
            }
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name}");
                Console.WriteLine($"{product.Price}");
                Console.WriteLine($"{product.Category}");
            }
            Console.WriteLine("List of products after grouping by category:");
            var groupedProducts = products.GroupBy(p => p.Category);
            foreach (var group in groupedProducts)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine("  " + product.Name);
                }
            }
        }
    }
}