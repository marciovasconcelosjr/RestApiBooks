using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApplication1.Model.Base;

namespace WebApplication1.Data.VO
{

    public class PersonVO
    {
        //[JsonPropertyName("code")]
        public long Id { get; set; }

        //[JsonPropertyName("Name")]
        public string FirstName { get; set; }

        //[JsonPropertyName("Last_Name")]
        public string LastName { get; set; }

        //[JsonIgnore]
        public string Address { get; set; }

        //[JsonPropertyName("Sex")]
        public string Gender { get; set; }

    }
}
