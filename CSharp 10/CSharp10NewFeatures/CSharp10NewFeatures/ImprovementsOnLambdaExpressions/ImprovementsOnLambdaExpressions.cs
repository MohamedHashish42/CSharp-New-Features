using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10NewFeatures.ImprovementsOnLambdaExpressions
{
    public class ImprovementsOnLambdaExpressions
    {
        public static Func<string> Example()
        {
            var func = () => "Mohamed";
            /*
             In C# before 10 we will need to write
             the previous line as the following
            */
            //Func<string> fun = () => "Mohamed";
            return func;
        }
    }
}
