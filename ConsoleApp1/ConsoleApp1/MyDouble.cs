using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyDouble
    {
        double[] arry=new double[0];
        public double[] arr { get => arry; }
        public void add(Double eded)
        {
            Array.Resize(ref arry, arry.Length + 1);
            arry[arry.Length - 1] = eded;
        }
    }
}
