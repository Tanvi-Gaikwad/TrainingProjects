using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Handson_network
{ }
//{
//public class Employee

//{
//    public int Id = 1;
//    public string name = "John Smith";
//    public string subject = "Physics";
//}

//internal class SerializationDemo
//{
//    public void JsonSerialize()
//    {
//        var weatherForecast = new Weather_Forecast
//        {
//            Date = DateTime.Parse("2019-08-01"),
//            TemperatureCelsius = 25,
//            Summary = "Hot"

//        };
//        //How to serialize from object to Json 
//        string jsonString = JsonSerializer.Serialize(weatherForecast);

//        //How to deserialize from Json to Object 
//        var obj = JsonSerializer.Deserialize<Weather_Forecast>(jsonString);
//        Console.WriteLine(obj.Date);
//        Console.WriteLine(obj.TemperatureCelsius);  
//        Console.WriteLine(obj.Summary);

//    }

//    public void XmlSerialize()
//    {
//        Employee bs = new Employee(); //creating object for employee file
//        XmlSerializer xs = new XmlSerializer(typeof(Employee));
//        TextWriter txtWriter = new StreamWriter(@"C:\Training\Serialization.xml");
//        xs.Serialize(txtWriter, bs);
//        txtWriter.Close();


//    }

//    public void XmlDeserialize() //to convert it back from xml to original form 
//    {
//        Employee bs = new Employee();
//        XmlSerializer xs = new XmlSerializer(typeof(Employee));
//        StreamReader reader = new StreamReader(@"C:\Training\Serialization.xml");
//        bs = (Employee)xs.Deserialize(reader);
//        Console.WriteLine("Employee Details");
//        Console.WriteLine("Id:" + bs.Id);
//        Console.WriteLine("Name:" + bs.name);
//        Console.WriteLine("Subject:" + bs.subject);
//    }
//    public class Weather_Forecast
//    {
//        public DateTimeOffset Date { get; set; }
//        public int TemperatureCelsius { get; set; }
//        public string Summary { get; set; }
//    }


//}
//}
 