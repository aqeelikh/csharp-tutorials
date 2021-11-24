using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_console_app;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!!";

            Console.WriteLine(message);

            var x = new MyClass();
            x.MyMethod(12,"cool");

            Coordinate point;
            //Console.Write(point.x); // Compile time error  

            point.x = 10;
            point.y = 20;
            Console.WriteLine(point.x); //output: 10  
            Console.WriteLine(point.y); //output: 20  
        }
    }
}