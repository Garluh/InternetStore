using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class AdminController : Controller
    {
        IDressRepository repository;

        public AdminController(IDressRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Список репозитория с товаром
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            return View(repository.Dresses);
        }

        /// <summary>
        /// Вывод окна редактирования товара
        /// </summary>
        /// <param name="dressId">Индификатор товара</param>
        /// <returns></returns>
        public ViewResult Edit(int dressId)
        {
            Dress dress = repository.Dresses.FirstOrDefault(b => b.DressId == dressId);

            return View(dress);
        }

        /// <summary>
        /// Сохранения товара
        /// </summary>
        /// <param name="dress"></param>
        /// <returns>RedirectToAction("Index")</returns>
        /// <returns>View(dress);</returns>
        /// Вызываем метод действия Index() для возвращения пользователю списка товаров.
        /// Если модель не валидна, мы снова визализируем представление Edit, чтобы пользователь смог внести коррективы.
        /// В нашей ситуации нельзя применить ViewBag,  поскольку пользователь находится в состоянии перенаправления
        /// Объект ViewBag передает данные между контроллеро и представлением, он не может удерживать данные дольше, чем длится HTTP-запрос.
        /// Данные ограничиваются сеансом одно пользователя(пользователи не видят объекты TempData друг друга) ихроняться достаточно долго, чтобы быть прочитанными
        [HttpPost]
        public ActionResult Edit(Dress dress)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDress(dress);
                TempData["message"] = string.Format("Изменения информации в товаре \"{0}\" сохранены", dress.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(dress);
            }
        }

    }
}