using System.ComponentModel.DataAnnotations;

namespace TrainingDotnet.Models.Entities
{
    public class Product
    {
        [Key]
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public double Product_price { get; set; }
        public int Product_quantity { get; set; }
        public string Product_des { get; set; }
        public int Cat_id { get; set; }
    }
}
