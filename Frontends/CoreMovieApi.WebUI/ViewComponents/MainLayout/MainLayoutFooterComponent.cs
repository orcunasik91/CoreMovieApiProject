using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutFooterComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}