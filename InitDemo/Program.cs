using System;

namespace InitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Age = 27 };

          //  p.Age = 50;

            Console.WriteLine(p.Age);
        }
    }
}
