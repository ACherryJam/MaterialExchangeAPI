using System.ComponentModel.DataAnnotations;

namespace MaterialExchangeAPI.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; } = null!;
    }
}
