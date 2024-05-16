using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace resume.Pages;

public class IndexModel : PageModel
{
    // public string Message { get; set; } = "";
    public string[] message { get; set; }
    public string[] skills { get; set; }

    public bool MoneySubmitted { get; set; } = false;

    public void OnGet()
    {
        message = new string[]
        {
            "Привет, я Junior-разработчик на JavaScript!",
            "Изучаю создание сайтов и веб-ресурсов.",
            "Стремлюсь к глубокой специализации в данной сфере.",
            "Соблюдаю сроки и четко выполняю поставленные задачи."
        };
        skills = new string[]
        {
            "Базовое знание языков html, css, JavaScript;",
            "Владение языками C#, C++, Python;",
            "Владение программами: PhpStorm, Figma, Visual Studio;",
            "Умение пользоваться GitHub;",
            "Умение работать с различными фреймворками;",
            "Моделирование визуальной составляющей мобильных приложений;",
            "Быстрая обучаемость;",
            "Усидчивость;",
            "Креативность мышления;",
            "Умение работать в команде.",
        };
    }

    public void OnPost()
    {
        MoneySubmitted = true;
    }
}