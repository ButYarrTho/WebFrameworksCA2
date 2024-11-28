using Microsoft.AspNetCore.Mvc;

namespace WebFrameworksCA2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseService _dbService;

        public HomeController(DatabaseService dbService)
        {
            _dbService = dbService;
        }

        public IActionResult Index()
        {
            _dbService.TestConnection();
            return View();
        }
    }
}