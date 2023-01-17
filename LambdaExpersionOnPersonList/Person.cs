using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpersionOnPersonList
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string sSN, string name, string address, int age)
        {
            SSN = sSN;
            Name = name;
            Address = address;
            Age = age;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
