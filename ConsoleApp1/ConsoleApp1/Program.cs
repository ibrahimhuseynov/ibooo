using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyDouble mydouble = new MyDouble();
            //mydouble.add(212);
            //mydouble.add(-12);
            //mydouble.add(42);
            //mydouble.add(23);


            //foreach (var b in mydouble.arr)
            //{
            //  Array.Reverse(mydouble.arr);
            //}

            //Console.ReadLine();
            //  Console.ReadLine();
            //MyString newmystring=new MyString();
            //  newmystring.add("a");
            //  newmystring.add("d");
            //  newmystring.add("z");
            //  newmystring.add("E");
            //  foreach (var item in newmystring.arr1)
            //  {
            //      Console.WriteLine(item.Replace('a','b'));

            //  }
            //  foreach (var item in newmystring.arr1)
            //  {
            //      Console.WriteLine(item.Contains("hesen"));

            //  }
            //  foreach (var item in newmystring.arr1)
            //  {
            //      Console.WriteLine(item.IndexOf('e'));

            //  }
            //  foreach (var item in newmystring.arr1)
            //  {
            //      Console.WriteLine(item.Clone());

            //  }
            //  foreach (var item in newmystring.arr1)
            //  {
            //      Console.WriteLine(item.Reverse());

            //  }
            //Book book1 = new Book();
            //Book book2 = new Book();
            //Book book3 = new Book();
            //Book book4 = new Book();
            //Console.WriteLine(book2.No);
            //Console.ReadLine();
            //list yaratmaq ve liste element add etmek
            List<int> lists = new List<int>();
            lists.Add(12);
            lists.Add(15);
            lists.Add(39);
            lists.Add(56);
            foreach(int item in lists)
            {
                Console.WriteLine(item);
            }
            //indi ise listen elementlerden her hansisa birini silek
            lists.Remove(39);
            //sildikden sonra elementleri cixisa verek
            foreach (var item in lists)
            {
                Console.WriteLine(item );
            }
            //listin elementlerini kecikden boyuye dogru duzek
            lists.Sort();
            //elementleri cixisa verek
            foreach(var item in lists)
            {
                Console.WriteLine(item);
            }
            //biz eger her hansissa indeksde olan elementi silmek istesek
            lists.RemoveAt(2);
            //daha sonra elementleri cagiraq ekrana//hal hazirda 2 ci index sildik
            foreach(var item in lists)
            {
                Console.WriteLine(item);
            }

        }
    }
}
