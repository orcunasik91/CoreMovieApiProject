using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutHeroComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}