using Microsoft.AspNetCore.Mvc;
namespace portfolio_II
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("process")]
        public IActionResult Process()
        {
            return Redirect("/");
        }
    }
}