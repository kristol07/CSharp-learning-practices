using System;
using System.Collections.Generic;
using Study;
using Study.Extensions;

namespace StudyCSharpApp
{
    class Program
    {   

        static void Main(string[] args)
        {

            //Calculator calculator = new Calculator();
            //int val = calculator.calculate(3, 5, Study.Math.Add);
            //Console.WriteLine(val);


            ////Employee dev = new Developer();
            ////((Developer)dev).m();
            ////dev.t();

            //Engine eng = new SunlightEngine();
            //Car car = new Car();
            //car.run(eng.Launch);
            //car.run(() => { Console.WriteLine("Wtf? lambda engine??"); });


            //MyEnumerator e = new MyEnumerator(100);

            //foreach (var num in e.NextNumber())
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.Write("\n");

            //Employee.info();
            //Employee emp123 = new Employee("123");
            //Employee.info();
            //Employee emp345 = new Employee("345");
            //Employee.info();

            //Console.WriteLine(emp123.Name);

            //foreach (var number in MyEnumerator.NextNumber())
            //{
            //    Console.WriteLine(number);
            //}

            //Printer printer = new Printer();
            ////Console.WriteLine("Hello {0}!", printer.Output());
            ////Console.WriteLine("Hello {0}", Printer.Output("wtf?"));
            //Console.WriteLine("Today is {0}", printer.PrintWeek(5));

            //int[] a = { 1, 2, 3 };
            //foreach (var i in a)
            //{
            //    Console.WriteLine($"{i}");
            //}

            MyList myList = new MyList();

            myList.Add(1);
            myList.Add(3);
            myList.Add(7);
            myList.Add(10);


            List<int> nList1 = myList.Transform(x => x * x);

            List<int> nList2 = myList.Filter(x => x > 5);


            foreach (var i in nList1)
            {
                Console.WriteLine(i);
            }

            foreach (var i in nList2)
            {
                Console.WriteLine(i);
            }


            List<int> nList3 = new List<int>();

            nList3.Add(1);
            nList3.Add(3);
            nList3.Add(7);
            nList3.Add(10);

            List<int> nList4 = nList3.Transform(x => x * 2);
            List<int> nList5 = nList3.Filter(x => x < 4);

            foreach (var i in nList4)
            {
                Console.WriteLine(i);
            }

            foreach (var i in nList5)
            {
                Console.WriteLine(i);
            }

        }
    }
}