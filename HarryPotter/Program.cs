using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace HarryPotter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://hp-api.herokuapp.com/api/characters");

            //httpWebRequest.ContentType = "text/json";
            //httpWebRequest.Method = "GET";
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    //ответ от сервера
            //    var json = streamReader.ReadToEnd();

            //    //Сериализация
            //    var result = JsonConvert.DeserializeObject<Information>(json);
            //    Console.WriteLine(result.ToString());
            //    Console.WriteLine("------------");
            //    Console.WriteLine(result);
            //    Console.WriteLine("------------");
            //}
            //Console.ReadLine();

            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("http://hp-api.herokuapp.com/api/characters");
                Console.WriteLine(json);
            }

            List<Information> list = new List<Information>();

            list.AddRange();

            Console.WriteLine(list[0].Actor);

        }
    }
}

