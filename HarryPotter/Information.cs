using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HarryPotter
{
    [Serializable]
    public class Information
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("yearOfBirth")]
        public object YearOfBirth { get; set; }

        [JsonProperty("ancestry")]
        public string Ancestry { get; set; }

        [JsonProperty("eyeColour")]
        public string EyeColour { get; set; }

        [JsonProperty("hairColour")]
        public string HairColour { get; set; }

        [JsonProperty("wand")]
        public Wand Wand { get; set; }

        [JsonProperty("patronus")]
        public string Patronus { get; set; }

        [JsonProperty("hogwartsStudent")]
        public bool HogwartsStudent { get; set; }

        [JsonProperty("hogwartsStaff")]
        public bool HogwartsStaff { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}