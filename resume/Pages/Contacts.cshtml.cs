using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace resume.Pages;

public class ContactsModel : PageModel
{
    public string Message { get; set; } = "";

    public bool FormSubmitted { get; set; } = false;

    public void OnGet()
    {
    }

    public void OnPost(string name)
    {
        Message = $"До скорой встречи, {name}!";
        FormSubmitted = true;
    }
}
    