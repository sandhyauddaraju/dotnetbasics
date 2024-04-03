using System;
using ClassLibrary1;

namespace MyApp
{
    internal class Employee1 : Person
    {
        protected override void Work()
        {
            base.Work();
        }
        static void Main(string[] args)
        {
            Employee1 p = new Employee1();
            p.Address = "NewYork"; //protected internal
            p.Name = "Test"; //protected



            Console.WriteLine("Hello World!");
        }
    }

}