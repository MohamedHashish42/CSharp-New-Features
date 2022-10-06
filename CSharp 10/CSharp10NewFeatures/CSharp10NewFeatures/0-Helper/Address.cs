using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10NewFeatures.Helper
{
    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }

        public Address(string country, string state)
        {
            Country = country;
            State = state;
        }
        public void Deconstruct(out string country, out string state)
        {
            (country, state) = (Country, State);
        }
    }
}
