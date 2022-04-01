using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyString
    {
        string[] arr = new string[0];
        public string[] arr1 { get { return arr; } }
        public void  add(string name)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = name;
        }
        
    }
}
