using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutPreloaderComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}