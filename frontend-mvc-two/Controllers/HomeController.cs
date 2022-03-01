using frontend_mvc_two.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace frontend_mvc_two.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeModel _homeModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _homeModel = new HomeModel();
        }

        public IActionResult Index()
        {
            _homeModel.Response = new PersonDetails
            {
                Name = "Qasim",
                Age = 36
            };

            return View(_homeModel);
        }

        [HttpPost]
        public IActionResult Index(HomeModel req)
        {
            string userName = req.User;

            if (req.User == "p")
            {
                _homeModel.Response = new PersonDetails
                {
                    Name = "Qasim",
                    Age = 36
                };

                return PartialView(_homeModel.Response.PartialViewName, _homeModel.Response);
            }

            _homeModel.Response = new CompanyDetails
            {
                Name = "Kainos",
                City = "London"
            };

            return PartialView(_homeModel.Response.PartialViewName, _homeModel.Response);
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