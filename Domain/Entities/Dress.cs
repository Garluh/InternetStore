namespace Domain.Entities
{
    public class Dress
    {
        public int DressId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Акционное предложение
        /// </summary>
        public string SpecOffer { get; set; }

        /// <summary>
        /// Категория платьев Готовое, Для примера, Партнерское
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Фото(URL)
        /// </summary>
        public string Image{ get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
