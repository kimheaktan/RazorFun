using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("{name}")]
        public ViewResult Home(string name)
        {
            return View();
        }
    }
}