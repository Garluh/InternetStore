using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Abstract;
using Moq;
using Domain.Entities;
using System.Collections.Generic;
using WebUI.Controllers;
using System.Linq;
using System.Web.WebPages.Html;
using WebUI.Models;
using System.Web.Mvc;
using WebUI.HtmlHelpers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            Mock<IDressRepository> mock = new Mock<IDressRepository>();
            mock.Setup(m => m.Dresses).Returns(new List<Dress>
            {
                new Dress {DressId = 1, Name = "Dress1" },
                new Dress {DressId = 2, Name = "Dress2" },
                new Dress {DressId = 3, Name = "Dress3" },
                new Dress {DressId = 4, Name = "Dress4" },
                new Dress {DressId = 5, Name = "Dress5" },
            });

            DressesController controller = new DressesController(mock.Object);
            controller.pageSize = 3;

            DressesListViewModel result = (DressesListViewModel)controller.List(null, 2).Model;

            List<Dress> dresses = result.Dresses.ToList();
            Assert.IsTrue(dresses.Count == 2);
            Assert.AreEqual(dresses[0].Name, "Dress4");
            Assert.AreEqual(dresses[1].Name, "Dress5");

        }

        [TestMethod]
        public void Can_generate_page_link()
        {
            System.Web.Mvc.HtmlHelper myHelper = null;
            PagingInfo paginigInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };
            Func<int, string> pageUrlDelegate = i => "Page" + 1;

            MvcHtmlString result = myHelper.PageLinks(paginigInfo, pageUrlDelegate);

            Assert.AreEqual(@"<a class=""btn bnt-default"" href=""Page1"">1</a>"
                    + @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>"
                    + @"<a class=""btn btn-default"" href=""Page3"">3</a>",
                    result.ToString());
            

        }

        [TestMethod]
        public void Can_Send_Paging_View_model()
        {
            Mock<IDressRepository> mock = new Mock<IDressRepository>();
            mock.Setup(m => m.Dresses).Returns(new List<Dress>
                {
                    new Dress {DressId = 1, Name = "Dress1" },
                    new Dress {DressId = 2, Name = "Dress2" },
                    new Dress {DressId = 3, Name = "Dress3" },
                    new Dress {DressId = 4, Name = "Dress4" },
                    new Dress {DressId = 5, Name = "Dress5" },
                });

            DressesController controller = new DressesController(mock.Object);
            controller.pageSize = 3;

            DressesListViewModel result = (DressesListViewModel)controller.List(null, 2).Model;

            PagingInfo paginigInfo = result.PagingInfo;
            Assert.AreEqual(paginigInfo.CurrentPage,2);
            Assert.AreEqual(paginigInfo.ItemsPerPage, 3);
            Assert.AreEqual(paginigInfo.TotalItems, 5);
            Assert.AreEqual(paginigInfo.TotalPages, 2);
        }
    }
}
