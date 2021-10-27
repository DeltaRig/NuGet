using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
            JValue text = new JValue("Manual Text");
            JValue date = new JValue(new DateTime(2000, 5, 23));

            array.Add(text);
            array.Add(date);

            string json = array.ToString();
            Console.WriteLine(json);

            Console.ReadLine(); // just to dont close the program
        }
    }
}
