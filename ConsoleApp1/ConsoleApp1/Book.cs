using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public int No { get;}
        private static  int _no;
        public Book()
        {
            _no ++;
            No = _no;
        }
        public string Name { get; set; }    
        public string AuthorName { get; set; }
        public int PageCount { get; set; }   
    }
}
