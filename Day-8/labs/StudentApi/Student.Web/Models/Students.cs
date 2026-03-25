using Newtonsoft.Json;
using System.Text.Json;

namespace Student.Web.Models
{
    public class Students
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Other = 3
    }
}
