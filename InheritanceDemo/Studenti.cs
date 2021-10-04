using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Studenti : Personi
    {
        public string FieldOfStudy;
        public double GPA;

        public override string ToString()
        {
            return $"{base.ToString()} \nField of study: {FieldOfStudy}\nGPA: {GPA}";
        }
    }
}
