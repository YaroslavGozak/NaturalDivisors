using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            var devisors = GetNaturalDivisors(54);
            PrintCollection(devisors);
            Console.ReadKey();
        }

        static List<int> GetNaturalDivisors(int number)
        {
            var devisors = new List<int>();
            var root = Math.Sqrt(number);
            var devisor = 1;

            while(devisor < root)
            {
                var rest = number % devisor;
                var result = number / devisor;
                if(rest == 0)
                {
                    devisors.Add(devisor);
                    if (devisor != result)
                        devisors.Add(result);
                }
                devisor++;
            }
            return devisors;
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Console.Write(item.ToString() + ", ");
            }
        }
    }
}
