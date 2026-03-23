
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateCityValidatedModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Required]
        [MinLength(3)]
        public string CityName { get; set; }
    }

    public void OnPost()
    {
        if (!ModelState.IsValid) return;
    }
}
