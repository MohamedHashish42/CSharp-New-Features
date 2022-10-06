using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10NewFeatures.AssignmentAndDeclarationInTheSameDeconstruction
{
    public class AssignmentAndDeclarationInTheSameDeconstruction
    {
        public static void Example()
        {
            var address = new Address("Egypt", "Dakahlia");

            //Assignment:
            string state = "Cairo";
            (string country/*Declaration*/, state) = address;

            Console.WriteLine(state);
        }
    }
}
    
