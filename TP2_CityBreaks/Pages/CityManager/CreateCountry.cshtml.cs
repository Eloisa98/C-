
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateCountryModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        public string CountryName { get; set; }

        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; }
    }

    public void OnPost()
    {
        if (!ModelState.IsValid) return;

        if (Input.CountryName[0] != Input.CountryCode[0])
        {
            ModelState.AddModelError("Input.CountryCode", "Deve começar com mesma letra");
        }
    }
}
