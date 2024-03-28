using Microsoft.AspNetCore.Mvc;

namespace DevOpsQuiz4_App.Controllers
{
    public class DatabaseAccessController : Controller
    {
        public string GetDatabaseAccessMessage()
        {
            return "Database access has already been done on April 14, 2023 by Maria Navarrete";
        }
    }
}
