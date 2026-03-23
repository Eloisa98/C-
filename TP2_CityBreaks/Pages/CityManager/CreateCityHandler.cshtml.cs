
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateCityHandlerModel : PageModel
{
    public string Message { get; set; }

    public void OnPost(string cityName)
    {
        Message = $"Cidade recebida: {cityName}";
    }
}
