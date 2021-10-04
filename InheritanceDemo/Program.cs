using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // To do: Testo metodat e krijuara nga ti

            Shteti kosova = new Shteti();
            kosova.PopulloShtetin();

            
            Console.WriteLine("Qytetaret e Kosoves:");

            foreach (var person in kosova.Personat)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }

            Console.WriteLine("Personat me mbiemer Gashi: \n");

            var personatMeMbiemerGashi = kosova.KthePersonatSipasMbiemrit("Gashi");

            foreach (var person in personatMeMbiemerGashi)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }



        }
    }
}
