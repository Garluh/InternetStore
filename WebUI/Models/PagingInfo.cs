using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        /// <summary>
        /// Общие кол-во элементов
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Кол-во элементов на странице
        /// </summary>
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Текущая страница
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Всего страниц
        /// </summary>
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}