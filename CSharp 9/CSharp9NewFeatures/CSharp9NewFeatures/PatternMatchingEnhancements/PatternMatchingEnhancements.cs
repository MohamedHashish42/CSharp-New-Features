using CSharp9NewFeatures.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.PatternMatchingEnhancements
{
    public class PatternMatchingEnhancements
    {
        public static bool IsSmall(Company company) =>
         company.Size is >= 1 and <= 10;

        public static bool IsMedium(Company company) =>
         company.Size is > 10 and <= 50;

        public static bool IsLarge(Company company) =>
        company.Size is > 50;


        public static string GetCompanySizeAsAWord(Company company)
        {
            var CompanySize = company.Size switch
            {
                >= 1 and <= 10 => "Small",
                > 10 and <= 50 => "Medium",
                > 50 => "Large",
                _ => "Unknown"
            };
            return CompanySize;
        }

        public static bool IsCompanyHaveName(Company company)
        {
            if (company.Name is not null)
                return true;
            else
                return false;
        }


    }
}
