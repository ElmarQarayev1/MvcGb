using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGb.Data;
using MvcGb.ViewModels;

namespace MvcGb.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        HomeViewModel hv = new HomeViewModel()
        {
            Categories = _context.Categories.ToList(),
            Projects=_context.Projects.Include(x=>x.Category).Include(x => x.ProjectImages).ToList(),
            Teams=_context.Teams.Include(x=>x.Socials).ToList(),
            Socials=_context.Socials.Include(x=>x.Team).ToList()
        };
        return View(hv);
    }


}

