
using Microsoft.AspNetCore.Mvc.RazorPages;
using CityBreaks.Web.Services;
using CityBreaks.Web.Models;

public class IndexModel : PageModel
{
    private readonly ICityService _service;

    public List<City> Cities { get; set; } = new();

    public IndexModel(ICityService service)
    {
        _service = service;
    }

    public async Task OnGet()
    {
        Cities = await _service.GetAllAsync();
    }
}
