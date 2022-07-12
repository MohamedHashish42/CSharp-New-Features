using CSharp9NewFeatures.Helper;
using CSharp9NewFeatures.InitOnlySetters;
using CSharp9NewFeatures.PatternMatchingEnhancements;
using CSharp9NewFeatures.Record;
using System;

#region Init Only Setters 
//InitOnlySetters.Example1();
#endregion

#region Pattern Matching Enhancements
//PatternMatchingEnhancementsExample();
#endregion

#region Record VS Class
RecordVSClass.Example();
#endregion

static void PatternMatchingEnhancementsExample()
{
    var company = new Company(7, "Company7", 9);
    Console.WriteLine(PatternMatchingEnhancements.IsSmall(company));
    Console.WriteLine(PatternMatchingEnhancements.GetCompanySizeAsAWord(company));
}



//namespace CSharp9NewFeatures
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}


