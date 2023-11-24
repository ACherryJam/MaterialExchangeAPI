using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialExchangeAPI.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
