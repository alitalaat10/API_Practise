using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TestRESTAPI.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string? notes { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<Item> Items { get; set;}
    }
}
