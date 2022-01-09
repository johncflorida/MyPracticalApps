using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MPA.Data;

namespace MPA.RazorLib.MPA.Pages;

public class EmployeesPageModel : PageModel
{
    private MPAContext db;

    public EmployeesPageModel(MPAContext injectedContext)
    {
        db = injectedContext;
    }

    public IQueryable<Employee>? Employees { get; set; } = null!;

    public void OnGet()
    {
        ViewData["Title"] = "MPA - Employees";
        Employees = db.Employees.OrderBy(c => c.Country).ThenBy(c => c.LastName).ThenBy(c => c.FirstName);

    }
}
