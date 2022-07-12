using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.Record
{
    public record Person(string FirstName, string LastName);

    #region Example 1
    public record Teacher(string FirstName, string LastName, int Grade)
                : Person(FirstName, LastName);
    #endregion

    #region Example 2
    public record Student : Person
    {
        public Student(string firstName, string LastName) : base(firstName, LastName)
        {
        }
    }
    #endregion
}
