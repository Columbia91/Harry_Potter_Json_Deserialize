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
            string json;
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString("http://hp-api.herokuapp.com/api/characters");
            }

            var information = JsonConvert.DeserializeObject<Information[]>(json);
            
            foreach (var item in information)
            {
                item.Show();
            }
        }
    }
}

