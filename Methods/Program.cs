using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double fees = 15;
            string explanation = "Amasya elması";

            
            
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Fees = 15;
            product1.Explanation = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Fees = 80;
            product2.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Fees);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("------------------------");
            }


            Console.WriteLine("-------------Methods----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12,10);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


// Do not repeat yourself ! DRY