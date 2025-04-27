using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutNavbarComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}