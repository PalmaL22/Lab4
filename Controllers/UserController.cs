using Microsoft.AspNetCore.Mvc;
using MonsalvoPalma.Models;
using System.Linq;

namespace MonsalvoPalma.Controllers;

public class UsersController : Controller
{
    private readonly UsersContext _context;

    public UsersController(UsersContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var users = _context.LpalmaTables.ToList();
        return View("MLviews", users);
    }
}