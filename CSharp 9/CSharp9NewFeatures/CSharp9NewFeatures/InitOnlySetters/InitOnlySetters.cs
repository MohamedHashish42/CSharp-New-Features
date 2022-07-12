using CSharp9NewFeatures.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.InitOnlySetters
{
    public class InitOnlySetters
    {
        public static void Example1()
        {
            Company company = new Company { Id = 1, Name = "Company 1" };
            //company.Id=2      //Not allowed
            company = new Company(2, "Company 2", 10);
            Console.WriteLine($"id: {company.Id} \nName: {company.Name}");
        }

    }
}
