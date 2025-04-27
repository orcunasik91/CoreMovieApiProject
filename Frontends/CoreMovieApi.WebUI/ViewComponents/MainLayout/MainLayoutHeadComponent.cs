using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutHeadComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}