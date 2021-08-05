using E_journal.Models;
using E_journal.Models.ViewModels;
using E_journal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace E_journal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGroupService _groupService;

        public HomeController(ILogger<HomeController> logger, IGroupService groupService)
        {
            _groupService = groupService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var groups = new GroupViewModel
            {
                GroupList = _groupService.Select()
            };

            return View(groups);
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
