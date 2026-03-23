
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateCityModel : PageModel
{
    [BindProperty]
    public string CityName { get; set; }

    public string Message { get; set; }

    public void OnPost()
    {
        Message = $"Cidade enviada: {CityName}";
    }
}
