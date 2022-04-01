using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string txt)
        {
            List<Book> Booklar = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(txt))
                {
                    Booklar.Add(book);
                }
            }
            return Booklar;
        }
        public void RemoveAllBookByName(string txt)
        {
            foreach (Book book in Books)
            {
                if (book.Name.Contains(txt))
                {
                    Books.Remove(book);
                }
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int minPC, int maxPC)
        {
            List<Book> Yenilist = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.PageCount > minPC && book.PageCount < maxPC)
                {
                    Yenilist.Add(book);
                }
            }
            return Yenilist;
        }
        public void RemoveByCode(int txt)
        {
            foreach (Book book in Books)
            {
                if (book.No == txt)
                {
                    Books.Remove(book);
                }
            }
        }
        public List<Book> SearchBooks(string txt)
        {
            List<Book> Yenibooklar = new List<Book>();
            foreach (Book book in Books)
            {
                string text = book.Name + book.AuthorName + book.PageCount;
                if (text.Contains(txt))
                {
                    Yenibooklar.Add(book);
                }
            }
            return Yenibooklar;
        }
    }
}
