using BookShop.Models;
using BookShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookStore()
        {
            List<Book> bookList = Data.getAllBooks();
            return View(bookList);
        }

        [HttpGet]
        public JsonResult GetBookInfo(int BookId)
        {
            Book book = Data.getBookInfo(BookId);
            return Json(book);
        }

        [HttpPost]
        public JsonResult PersonPerBook(int BookId)
        {
            List<Person> personList = Data.getPersonByBook(BookId);
            return Json(personList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
