using CoreMovieApi.WebUI.Dtos.MovieDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreMovieApi.WebUI.Controllers;
public class HomeController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public HomeController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7251/api/Movies/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}