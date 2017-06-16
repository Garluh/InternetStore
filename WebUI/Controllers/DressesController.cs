using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class DressesController : Controller
    {
        private IDressRepository repository;
        public int pageSize = 5;                       //Указываем кол-во товаров отображаемых на одной странице

        public DressesController(IDressRepository repo)
        {
            repository = repo;
        }



        public ViewResult List(string category, int page = 1)            //Необязательный параметр page=1 означает, что пр ивызове List() без параметров будет отображаться первая страница списка товаров
        {
            DressesListViewModel model = new DressesListViewModel
            {
                Dresses = repository.Dresses
                .Where(b => category == null || b.Category == category)
                .OrderBy(dress => dress.DressId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = page,
                     ItemsPerPage = pageSize,
                     TotalItems = category == null ? 
                         repository.Dresses.Count() :
                         repository.Dresses.Where(dress => dress.Category == category).Count()
                 },
                 CurrentCategory = category
            };

            return View(model);
        }
    }
}