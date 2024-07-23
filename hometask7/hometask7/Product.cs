using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask7
{
 
     public class Product  
    {
        public string name {  get; set; } = string.Empty;
        public double price { get; set; } 
        public int id { get; set; }
        public int amount { get; set; }

        public Product() { }
        public Product(string name, double price, int id, int amount)
        {
            this.name = name;
            this.price = price;
            this.id = id;
            this.amount = amount;
        }
        public void Input()
        {
            Console.WriteLine("Введите ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество:");
            amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Введите название товаров (количество {amount}) соответствующее id {id}:");
                name = Console.ReadLine();
                Console.WriteLine("Введите цены на них");
                price = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void Output()
        {
            Console.WriteLine($"ID товара: {id}" +
                $"общее количество {amount}");
            for (int i = 0;i < amount; i++)
            {
                Console.WriteLine(name, price +"/n");
            }
        }
    }
    public class Inventory 
    {
        Product? firsProductsGroup;
        Product? secondProductsGroup;


        public void Inventorization()
        {
            Product firsProductsGroup = new Product();
            firsProductsGroup.Input();
            firsProductsGroup.Output();
            Product secondProductsGroup = new Product();
            secondProductsGroup.Input();
            secondProductsGroup.Output();

            Product[] products = new Product[] { firsProductsGroup, secondProductsGroup };
            for (int i = 0; i< products.Length; i++)
            {
                Console.WriteLine("Общая сумма товаров и количество:");
                var summ =+ products[i].price;
                Console.WriteLine(summ);
                var totalamount =+ products[i].amount;

            }
        }
    }
}
