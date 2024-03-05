using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    
    internal class Test
    {

        public static void Izvedi()
        {
            List<int> selectedNumbers = new List<int>();
            Random random = new Random();

            while (selectedNumbers.Count < 7)
            {
                int number = random.Next(1, 46); 
                if (!selectedNumbers.Contains(number))
                {
                    selectedNumbers.Add(number);
                }
            }

            Console.Write("Odabrani brojevi su: ");
            foreach (int num in selectedNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}