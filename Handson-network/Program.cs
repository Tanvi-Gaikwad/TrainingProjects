using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Handson_network.Person;

namespace Handson_network
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FileRead variable = new FileRead();
            //variable.Read_file();
            //Console.Read();

            //SerializationDemo srlObj = new SerializationDemo();
            //srlObj.JsonSerialize();
            //Console.ReadLine();

            //GenericsDemo genericsDemo = new GenericsDemo();
            //genericsDemo.ShowSalaryReport(400.20);
            //genericsDemo.ShowAgeReport(30);
            //genericsDemo.ShowGenderReport()



            //FileStream fileObj = new FileStream(@"\C:Training\Serialization1.txt", FileMode.CreateNew, FileAccess.Write);
            //StreamWriter streamObj = new StreamWriter(fileObj);
            //streamObj.WriteLine(personObj.Name);
            //streamObj.WriteLine(personObj.Age); 
            //streamObj.WriteLine(personObj.City);
            //fileObj.Close();
            //streamObj.Close();


            //Person personObj = new Person();
            //personObj.XmlSerialize();


            //{
            serializationdemo srObj = new serializationdemo();
            //    srObj.XmlDeserialize();
            //}
            //Console.ReadLine();
            srObj.JsonSerialize();


            Console.ReadLine();



        }

        //private static serializationdemo serializationdemo()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
