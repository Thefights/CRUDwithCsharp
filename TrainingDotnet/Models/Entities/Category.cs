using System.ComponentModel.DataAnnotations;

namespace TrainingDotnet.Models.Entities
{
    public class Category
    {
        [Key]
        public int Cat_id { get; set; }
        public string Cat_name { get; set; }
        public string Cat_des { get; set; }

    }
}
