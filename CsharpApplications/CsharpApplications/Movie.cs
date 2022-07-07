using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplications
{
    internal class Movie
    {
        public void CreateMovie()
        { //Step 1 How to create file?

            System.IO.FileStream fileStreamObj = new FileStream("C:\\Training\\movie.txt", FileMode.Create, FileAccess.Write);

            //Step 2 How to write file?
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("MovieId:123");
            streamWriter.WriteLine("MovieName:RRR");
            streamWriter.WriteLine("MovieDesc:Action");
            streamWriter.WriteLine("MovieLanguage:Telugu");
            streamWriter.Close();//close writing operation
            fileStreamObj.Close();//close file operation 
            Console.WriteLine("File operation completed");
        }

            public void SelectMovies()
            { FileStream fileStreamObj = new FileStream(@"C:\Training\movie.txt", FileMode.Open, FileAccess.Read);

                StreamReader streamReader = new StreamReader(fileStreamObj);
                Console.WriteLine(streamReader.ReadLine());
                Console.WriteLine(streamReader.ReadLine());
                Console.WriteLine(streamReader.ReadLine());
                Console.WriteLine(streamReader.ReadLine());
                fileStreamObj.Close();

                //how to read all the date from file?
                //Console.WriteLine(streamReader.ReadToEnd());

             //   while (streamReader.Peek()>0)
               // {
                 //   Console.WriteLine(streamReader.ReadLine());
                   // line.split(':');

              //}

                //How to declare array?
                //Fixed array and dynamic array?

                

            }
    }
}
