using System.ComponentModel.DataAnnotations;

namespace MaterialExchangeAPI.DTO
{
    /// <summary>
    /// Формат получения данных о продавце
    /// </summary>
    public class GetSellerDTO
    {
        /// <summary>
        /// ID продавца
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// Имя продавца
        /// </summary>
        /// <example>Олег</example>
        public string? Name { get; set; }
    }

    /// <summary>
    /// Формат создания продавца
    /// </summary>
    public class CreateSellerDTO
    {
        /// <summary>
        /// Имя продавца
        /// </summary>
        /// <example>Олег</example>
        [Required]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Формат изменения данных о материале
    /// </summary>
    public class UpdateSellerDTO
    {
        /// <summary>
        /// Имя продавца
        /// </summary>
        /// <example>Артём</example>
        public string? Name { get; set; }
    }
}
