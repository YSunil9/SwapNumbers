using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    internal class SwapNumbers
    {
        public static void SwapFourNumbers(int a, int b, int c, int d)
        {
            int temp = 0;
            Console.WriteLine("numbers{0} {1} {2} {3} \n",a, b, c, d);
           
            temp = a;
            a = b;
            b = c;
            c = d;
            d = temp;


            Console.WriteLine("swap{0} {1} {2} {3}\n", a, b, c, d);


        }
    }
}
