using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] winningNums = numGen();

            if (isWinner(winningNums, getChoices())> 0)
            {
                Console.WriteLine("you Win");
            }
            else
            {
                Console.WriteLine("You lost");
            }
            Console.ReadKey();
        }

        private static int[] numGen()
        {
            int[] t = new int[5];
            bool inT = false;
            for (int i = 0; i < t.Length; i++)
            {

                foreach (var item in t)
                { inT = false;
                    do
                    {
                        int rand = rnd.Next(1, 91);
                        if (rand != item)
                        {
                            t[i] = rand;
                            inT = true;
                        }
                    } while (inT == false);
                }
            }
            return t;
        }
        static int[] getChoices() {
            string c;
            int[] choices = new int[5];

            for (int i = 0; i < choices.Length; i++)
            {
                Console.Write("adja meg az " + (i + 1) + "ik számát");
                c = Console.ReadLine();
                choices[i] = int.Parse(c);

            }
            return choices;
        }
        static int isWinner(int[] collection, int[] setOfVals) {
            int count = 0;
            for (int i = 0; i < setOfVals.Length; i++)
            {
                if (collection.Contains(setOfVals[i]))
                {
                    count++;
                } 
            }
            return count;
        }
    
    }
}
