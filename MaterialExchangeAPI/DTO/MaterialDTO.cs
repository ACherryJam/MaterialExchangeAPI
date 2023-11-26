using System.ComponentModel.DataAnnotations;

namespace MaterialExchangeAPI.DTO
{
    /// <summary>
    /// Формат получения данных о материале
    /// </summary>
    public class GetMaterialDTO
    {
        /// <summary>
        /// ID материала
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// Имя материала
        /// </summary>
        /// <example>Кирпич</example>
        public string? Name { get; set; }

        /// <summary>
        /// Цена продажи материала
        /// </summary>
        /// <example>42</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID продавца материала
        /// </summary>
        /// <example>1</example>
        public int SellerId { get; set; }
    }

    /// <summary>
    /// Формат создания материала
    /// </summary>
    public class CreateMaterialDTO
    {
        /// <summary>
        /// Имя материала
        /// </summary>
        /// <example>Кирпич</example>
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// Цена продажи материала
        /// </summary>
        /// <example>42</example>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// ID продавца материала
        /// </summary>
        /// <example>1</example>
        public int SellerId { get; set; }
    }

    /// <summary>
    /// Формат изменения данных о материале
    /// </summary>
    public class UpdateMaterialDTO
    {
        /// <summary>
        /// Имя материала
        /// </summary>
        /// <example>Бетон</example>
        public string? Name { get; set; }

        /// <summary>
        /// Цена продажи материала
        /// </summary>
        /// <example>43</example>
        public decimal Price { get; set; }

        /// <summary>
        /// ID продавца материала
        /// </summary>
        /// <example>2</example>
        public int SellerId { get; set; }
    }
}
