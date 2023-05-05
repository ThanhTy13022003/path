using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. combine
            string path = Path.Combine(@"C:\Users\Lenovo\Desktop\laptrinhmang\tu hoc\path\Test","tuhochoai.cc","concho.ccc");
            Console.WriteLine(path);
             //2.ChangeExtension
            string path2 = Path.ChangeExtension(path,"md");
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
