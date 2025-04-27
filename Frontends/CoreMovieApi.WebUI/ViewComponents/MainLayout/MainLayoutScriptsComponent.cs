using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutScriptsComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}