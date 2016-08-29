using Microsoft.AspNetCore.Mvc;

namespace Pluralsight.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello from the controller";
        }
    }
}
