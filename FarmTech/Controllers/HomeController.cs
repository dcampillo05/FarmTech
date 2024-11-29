using FarmTech.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarmTech.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {

            HomeModel model = new HomeModel();

            model.Nome = "Daniel";
            model.Email = "dani.campillo05@gmail.com";

            return View();
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
