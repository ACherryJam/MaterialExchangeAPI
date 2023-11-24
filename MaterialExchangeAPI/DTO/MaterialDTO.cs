namespace MaterialExchangeAPI.DTO
{
    public class GetMaterialDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
    }

    public class CreateMaterialDTO
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
    }

    // Id is passed as an URL argument
    public class UpdateMaterialDTO
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
    }
}
