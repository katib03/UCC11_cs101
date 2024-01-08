using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace P03_TypeConvertion
{
    internal class ImplicitClass1
    {

        public static void Main(string[] args)
        {

            string e = "arı bilgi";
            char f = 'a';

            object g = e + " " + f;

            Console.WriteLine(g);

        }





    }
}
