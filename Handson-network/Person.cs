using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Handson_network
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string City { get; set; }

        internal class serializationdemo
        {
            public object Name { get; private set; }

            public void XmlSerialize()
            {
                Person bs = GetData();
                XmlSerializer xs = new XmlSerializer(typeof(Person));
                TextWriter txtWriter = new StreamWriter(@"C:\Training\Serialization1.xml");
                xs.Serialize(txtWriter, bs);
                txtWriter.Close();
            }

            public void JsonSerialize()
            {
                var Person = new Person()
                {
                    Name = "Trace",
                    Age = 25,
                    City = "Blr",

                };


            //    public void XmlDeserialize()
            //{
            //    Person bs = new Person();
            //    XmlSerializer xs = new XmlSerializer(typeof(Person));
            //    StreamReader reader = new StreamReader(@"C:\Training\Serialization1.xml");
            //    bs = (Person)xs.Deserialize(reader);
            //    Console.WriteLine("Person Details");
            //    Console.WriteLine("Person Name" + bs.Name);
            //    Console.WriteLine("Person Age" + bs.Age);
            //    Console.WriteLine("Person City" + bs.City);
            }
                public Person GetData()
            {
                Person personObj = new Person();
                Console.WriteLine("Enter Person's Name:");
                personObj.Name = (Console.ReadLine());
                Console.WriteLine("Enter Person's Age:");
                personObj.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Person's City");
                personObj.City = (Console.ReadLine());
                return personObj;
            }
        }
    }
}


