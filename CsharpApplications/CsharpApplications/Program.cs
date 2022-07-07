using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("Enter value A:");
            //a = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine("Enter value B:");
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;

            //How to print/display output?
            //Console.WriteLine("Output:");
            //Console.Read();//How to read keyboard input?
            /*for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);

            }
        }*/

            //Event eventObj = new Event(); //How to create object?
            //eventObj.CreateEvent();
            //eventObj.SelectEvents();
            //Console.Read();//How to read keyboard input?

            Movie movie = new Movie();
            //movie.CreateMovie();

            /*string MovieId, MovieName, MovieDesc, MovieLanguage;
            Console.WriteLine("Enter MovieId:");
            MovieId = (Console.ReadLine());
            Console.WriteLine("Enter MovieName:");
            MovieName = (Console.ReadLine());
            Console.WriteLine("Enter MovieDesc:");
            MovieDesc = (Console.ReadLine());   
            Console.WriteLine("Enter MovieLanguage:");
            MovieLanguage = (Console.ReadLine());*/


            // Example of Values
            string[] Values = new string[5];
            Values[0] = "A";
            Values[1] = "B";
            Values[2] = "C";
            Values[3] = "D";
            Values[4] = "E";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Values[i]);
            }

            Console.ReadLine();
        }
    }
}

    //Return type methods- int, string, float, decimal, object 

    //No return type method- void 


