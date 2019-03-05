using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HarryPotter
{
    public class Wand
    {
        [JsonProperty("wood")]
        public string Wood { get; set; }

        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("length")]
        public object Length { get; set; }
    }
}
