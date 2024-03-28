using Microsoft.AspNetCore.Mvc;

namespace DevOpsQuiz4_App.Controllers
{
    public class DatabaseAccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
