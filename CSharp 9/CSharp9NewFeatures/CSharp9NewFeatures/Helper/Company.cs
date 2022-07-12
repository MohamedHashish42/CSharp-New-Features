using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.Helper
{
    public class Company
    {
        /*
        init means we can set id only when we init a company opject  
        */
        public int Id { get; init; }
        public string Name { get; set; }
        public int Size { get; set; }
        public Company()
        {
        }
        public Company(int id, string name,int size)
        {
            Id = id;
            Name = name;
            Size = size;
        }
    }
}
