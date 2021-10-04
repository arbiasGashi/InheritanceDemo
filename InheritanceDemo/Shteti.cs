using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceDemo
{
    public class Shteti
    {
        public string Name;
        public List<Personi> Personat = new List<Personi>();

        /*
         * Modifiko metoden Popullo shtetin, Nacionalitetin here vendose Kosovar here Albanian
         */

        public void PopulloShtetin()
        {
            List<string> firstNames = new List<string> { "Alban", "Teuta", "Kreshnik", "Abetare", "Muhamed", "Sadije", "Rinor", "Edmonda", "Ermir", "Ermira", "Fidan", "Drita" };
            List<string> lastNames = new List<string> { "Gashi", "Berisha", "Krasniqi", "Rama", "Surdulli", "Leci", "Dragusha", "Thaqi" };

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Personi personi = new Personi()
                {
                    FirstName = firstNames[rnd.Next(0, firstNames.Count)],
                    LastName = lastNames[rnd.Next(0, lastNames.Count)],
                    Nationality = "Kosovar"
                };

                Personat.Add(personi);
            }

        }

        /*
         * To do:
         * Implemento metodat e meposhtme KthePersonatSipasMbiemrit dhe KthePersonatSipasEmrit pa perdorur LINQ
         */

        public List<Personi> KthePersonatSipasMbiemrit(string mbiemri)
        {
            return Personat.Where(x => x.LastName == mbiemri).ToList();
        }

        public List<Personi> KthePersonatSipasEmrit(string emri)
        {
            return Personat.Where(x => x.FirstName == emri).ToList();
        }

        /*
         * To do:
         * Implemento metoden qe kthen personat sipas nacionalitetit, p.sh Kosovar - kthen te gjithe kosovaret, apo Albanian qe kthen te gjithe
         * shqiptaret. Perdor LINQ.
         */
        public List<Personi> KthePersonatSipasNacionalitetit(string emri)
        {
            return null; // Implement here the logic
        }

    }
}
