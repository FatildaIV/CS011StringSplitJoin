using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS011StringSplitJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            //// Part A: "num num num num" using Write
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.Write(" ");
            //Console.Write(num);
            //Console.WriteLine();
            Console.WriteLine("{0}", OpakovatText(num.ToString()," ", 8));

            //// Part B: "numnumnumnum" using Write
            //Console.Write(num);
            //Console.Write(num);
            //Console.Write(num);
            //Console.WriteLine(num);
            //Console.WriteLine();
            Console.WriteLine("{0}", OpakovatText(num.ToString(), "", 8));

            //// Part C: "num num num num" using {0}
            //Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}", OpakovatText(num.ToString(), " ", 8));

            //// Part D: "numnumnumnum" using {0}
            //Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0}", OpakovatText(num.ToString(), "", 8));

            Console.ReadKey();
        }

        static string OpakovatText(string text,string oddelovac, int pocet)
        {
            if (pocet == 0) return ("");
            return 
                string.Join(
                    oddelovac, 
                    (string.Format(
                        "{0};{1}",
                        text, 
                        OpakovatText(
                            text,
                            oddelovac,
                            pocet - 1))).Split(';'));
        }
    }
}
