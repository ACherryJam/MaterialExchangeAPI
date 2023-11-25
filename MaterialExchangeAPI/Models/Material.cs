using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialExchangeAPI.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public int? SellerId { get; set; } = null;
        public virtual Seller Seller { get; set; }
    }
}
