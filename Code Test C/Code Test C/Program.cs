using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int input=0;


            do
            {
                int.TryParse(Console.ReadLine(), out input);
            }while (input < 1 || input > 1000);

            for (int i = 1; i <= input; i++)
            {
                string temp = "";
                if (i % 3 == 0)
                {
                    temp += "X";
                                   }
                if (i % 5 == 0)
                {
                    temp += "Y";
                }
                if (i % 7 == 0)
                {
                    temp += "Z";
                }

                if(temp != "")
                    Console.Write(" " + temp);
                else
                    Console.Write(" "+i);
            }
            Console.ReadKey();
        }
    }
}
