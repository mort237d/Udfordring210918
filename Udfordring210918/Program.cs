using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udfordring210918
{
    class Program
    {
        static void Main(string[] args)
        {
            //HeltalNulNegativttal();
            HvilketTalErStørst();
        }

        public static void HeltalNulNegativttal()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {
                Console.WriteLine("Dit tal er positivt");
            }
            else if (input == 0)
            {
                Console.WriteLine("Dit tal er nul");
            }
            else
            {
                Console.WriteLine("Dit tal er negativt");
            }
        }

        public static void HvilketTalErStørst()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            if (input < input2)
            {
                Console.WriteLine(input2 + " er det største tal");
            }
            else
            {
                Console.WriteLine(input + " er det største tal");
            }
        }
    }
}
