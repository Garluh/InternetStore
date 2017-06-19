using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Dress
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "ID")]
        public int DressId { get; set; }

        [Display(Name ="Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название")]
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Пожалуйста, укажите описание")]
        [Display(Name = "Описание")]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        [Display(Name = "Специальное предложение")]
        /// <summary>
        /// Специальное предложение
        /// </summary>
        public string SpecOffer { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию")]
        /// <summary>
        /// Категория платьев Готовое, Для примера, Партнерское
        /// </summary>
        public string Category { get; set; }

        [Display(Name = "Изображение")]
        /// <summary>
        /// Фото(URL)
        /// </summary>
        public string Image{ get; set; }

        [Display(Name = "Цена(грн)")]
        [Required]
        [Range(0.01,double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение цены")]
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
