using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutLoginModalComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}