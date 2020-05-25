using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            Console.SetWindowSize(30,11);
            Creator[] creators = new Creator[2];
            creators[0] = new ComputerCreator();
            creators[1] = new IpodCreator();

            foreach (Creator cr in creators)
            {
                if (cr is ComputerCreator)
                    productList.Add(cr.FactoryMethod("Notebook", 60000, 80000));

                if (cr is IpodCreator)
                    productList.Add(cr.FactoryMethod("audio,mp3,mp4", 25000, 36000));
            }

            foreach (Product pr in productList)
            {
                Console.WriteLine("Обьект класса {0};\n" + "Описание: {1};\n" + "Закупочная цена: {2};\n" + "Цена продажы: {3};\n",
                     pr.GetType().Name,
                     pr.Description,
                     pr.PurchasePrice,
                     pr.Price);
            }

            Console.ReadLine();
        }
    }
}
