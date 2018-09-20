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
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Vil du finde ud af om du har et (p)ositivt eller negativt tal?");
                Console.WriteLine("Eller vil du finde det (s)tørste tal af to værdier?");

                Console.Write("> ");
                ConsoleKeyInfo answer = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                switch (answer.KeyChar)
                {
                    case 'p':
                        HeltalNulNegativttal();
                        loop = false;
                        break;
                    case 's':
                        BestSolutonHvilketTalErStørst();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Wrong key... Try again...");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
            }
        }

        public static void HeltalNulNegativttal()
        {
            Console.WriteLine("Skriv et tal du ønsker at finde ud af om er positivt eller negativt:");

            Console.Write("> ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine(input + " er et positivt tal");
            }
            else if (input == 0)
            {
                Console.WriteLine(input + " er nul");
            }
            else
            {
                Console.WriteLine(input + " er et negativt tal");
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

        public static void BestSolutonHvilketTalErStørst()
        {
            Console.WriteLine("Skriv to numre, hvor du ønsker at finde den største værdi.");
            Console.WriteLine("Format: A B - eksempel 12 34.");

            Console.Write("> ");
            string[] intInputs = Console.ReadLine().Split();
            int input = Convert.ToInt32(intInputs[0]);
            int input2 = Convert.ToInt32(intInputs[1]);

            if (input < input2)
            {
                Console.WriteLine(input2 + " er det større end " + input);
            }
            else if (input == input2)
            {
                Console.WriteLine(input + " og " + input2 + " er lige store");
            }
            else
            {
                Console.WriteLine(input + " er det større end " + input2);
            }
        }
    }
}
