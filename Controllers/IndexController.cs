using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class IndexController : Controller {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }
    }
}