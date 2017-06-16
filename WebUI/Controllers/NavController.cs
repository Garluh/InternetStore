using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {

        private IDressRepository repository;

        public NavController(IDressRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.CurrentCategory = category;

            IEnumerable<string> categories = repository.Dresses
                .Select(dress => dress.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}