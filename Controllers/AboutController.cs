using ASP.NET_task2.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_task2.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var works = new List<Work>
        {
            new Work
            {
                Id = 1,
                Title_Style = "bxs-bulb",
                Title = "Our Vision",
                Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."
            },
            new Work
            {
                Id = 2,
                Title_Style = "bx-revision",
                Title = "Our Mission",
                Description = "Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis."
            },
            new Work
            {
                Id = 3,
                Title_Style = "bxs-select-multiple",
                Title = "Our Goal",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."
            }
        };
        
        var model = new HomeIndexVM
        {
            Works = works
        };
        
        return View(model);
    }
}