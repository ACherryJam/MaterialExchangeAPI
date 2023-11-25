using System.ComponentModel.DataAnnotations;

namespace MaterialExchangeAPI.DTO
{
    public class GetMaterialDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int? SellerId { get; set; }
    }

    public class CreateMaterialDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? SellerId { get; set; } = null;
    }

    // Id is passed as an URL argument
    public class UpdateMaterialDTO
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int? SellerId { get; set; }
    }
}
