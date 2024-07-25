using BusinessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager cm = new CategoryManager();

            ProductManager pm = new ProductManager();
            foreach(var item in pm.GetAll())
            {
                Console.WriteLine("ID: " + item.ProductID + " Ürün Adı: " + item.ProductName + " Stok: " + item.Stock);
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();

            string proname = "Fırın";
            foreach(var item in pm.GetByName(proname))
            {
                Console.WriteLine("ID: " + item.ProductID + " Ürün Adı: " + item.ProductName + " Stok: " + item.Stock);
            }

            //Category c = new Category();
            //c.CategoryID = 3;
            //c.CategoryName = "Mobilya ve Oturma Grubu";
            //cm.BLUpdate(c);

            //foreach (var item in cm.GetAll())
            //{
            //    Console.WriteLine("ID: " + item.CategoryID + " - Kategori Adı: " + item.CategoryName);
            //}
            //Category ct = new Category();
            //ct.CategoryName = "Halılar";
            //cm.BLAdd(ct);
            //cm.BLDelete(6);
            Console.Read();
        }
    }
}
