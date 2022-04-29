using System;

namespace OOPChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating objects and calling methods.
            Person a = new Person();
            a.Greet();

            Student b = new Student();
            b.SetAge(43);
            b.Greet();
            b.ShowAge();

            Professor c = new Professor();
            c.SetAge(52);
            c.Greet();
            c.Explain();
        }
    }
}
