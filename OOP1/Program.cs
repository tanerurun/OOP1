using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Id = 1;
            product.Stok = 400;
            product.Price = 10;



            Product product1 = new Product();
            product1.Name = "elma";
            product1.Id = 4;
            product1.Price = 550;
            product1.Stok = 40;

            ProductManager productManager = new ProductManager();
            productManager.Add(product);

            productManager.Update(product1);


            Console.WriteLine("Hello World!");
        }
    }
}
