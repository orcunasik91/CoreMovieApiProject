using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
