using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.Record
{
    #region Person Record
    public record PersonRecord(string FirstName, string LastName);
    #endregion

    #region Person Class
    public class PersonClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonClass(string first, string last) =>
            (FirstName, LastName) = (first, last);

    }
    #endregion


    public class RecordVSClass
    {
        public static void Example()
        {
            var personR1 = new PersonRecord("Mohamed", "Hashish");
            var personR2 = new PersonRecord("Mohamed", "Hashish");

            Console.WriteLine("\t(Record Type)\t\n");
            Console.WriteLine($"ToString {personR1}");
            Console.WriteLine($"Equals {Equals(personR1, personR2)}");
            Console.WriteLine($"== {personR1 == personR2}");
            Console.WriteLine($"!= {personR1 != personR2}");
            Console.WriteLine($"Hash code of personR1 {personR1.GetHashCode()}");
            Console.WriteLine($"Hash code of personR2 {personR2.GetHashCode()}");
            Console.WriteLine($"ReferenceEquals {ReferenceEquals(personR1, personR2)}");

            Console.WriteLine("With Keyword");
            var personR3 = personR1 with
            {
                LastName = "Khalid"
            };
            Console.WriteLine(personR3);

            Console.WriteLine("\n===================================================================\n");

            var personC1 = new PersonClass("Mohamed", "Hashish");
            var personC2 = new PersonClass("Mohamed", "Hashish");

            Console.WriteLine("\t(Class Type)\t\n");
            Console.WriteLine($"ToString {personC1}");
            Console.WriteLine($"Equals {Equals(personC1, personC2)}");
            Console.WriteLine($"== {personC1 == personC2}");
            Console.WriteLine($"!= {personC1 != personC2}");
            Console.WriteLine($"Hash code of personC1 {personC1.GetHashCode()}");
            Console.WriteLine($"Hash code of personC2 {personC2.GetHashCode()}");
            Console.WriteLine($"ReferenceEquals {ReferenceEquals(personC1, personC2)}");

            Console.WriteLine("\n===================================================================\n");


        }
    }



}
