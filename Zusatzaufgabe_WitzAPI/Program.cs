using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zusatzaufgabe_WitzAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "ja";

            while (input == "ja")
            {
                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string jsonData = new StreamReader(responseStream).ReadToEnd();

                JArray array = JArray.Parse(jsonData);

                foreach (JObject obj in array)
                {
                    string joke = obj["text"].ToString();
                    Console.WriteLine(joke);
                }

                    Console.WriteLine("Möchtest du noch einen Witz hören? (ja/irgendeine Taste zum beenden)");
                    input = Console.ReadLine().ToLower();
            }
        }
    }
}
