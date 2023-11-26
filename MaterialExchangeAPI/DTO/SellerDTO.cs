using System.ComponentModel.DataAnnotations;

namespace MaterialExchangeAPI.DTO
{
    public class GetSellerDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CreateSellerDTO
    {
        [Required]
        public string? Name { get; set; }
    }

    // Id is passed as an URL argument
    public class UpdateSellerDTO
    {
        public string? Name { get; set; }
    }
}
