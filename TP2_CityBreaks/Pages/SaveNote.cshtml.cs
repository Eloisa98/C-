
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class SaveNoteModel : PageModel
{
    [BindProperty]
    public string Content { get; set; }

    public string FileName { get; set; }

    public async Task OnPostAsync()
    {
        var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");
        Directory.CreateDirectory(dir);

        FileName = $"note-{DateTime.Now.Ticks}.txt";
        var path = Path.Combine(dir, FileName);

        await System.IO.File.WriteAllTextAsync(path, Content);
    }
}
