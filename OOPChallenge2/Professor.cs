using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge2
{
    //sub-class inherit from base class Person
    internal class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining.");
        }
    }
}
