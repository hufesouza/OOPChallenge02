using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge2
{
    //sub-class inherit from base class Person
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studing.");
        }
        public void ShowAge()
        {
            Console.WriteLine($"I am {age} years old.");
        }
    }
}
