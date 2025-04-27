using Microsoft.AspNetCore.Mvc;

namespace CoreMovieApi.WebUI.ViewComponents.MainLayout;
public class MainLayoutSignupModalComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}