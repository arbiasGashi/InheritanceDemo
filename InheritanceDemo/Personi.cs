using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Personi
    {
        public Guid IdentificationNumber;
        public string FirstName;
        public string LastName;
        public string Nationality;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public Personi()
        {
            IdentificationNumber = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"ID: {IdentificationNumber}\nName: {FullName}\nNationality: {Nationality}";
        }


    }
}
