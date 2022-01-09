using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MPA.Data;

namespace MPA.Pages;

public class supplierModel : PageModel
{
    private MPAContext db;

    public supplierModel(MPAContext injectedContext)
    {
        db = injectedContext;
    }

    public IQueryable<Supplier>? Suppliers { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers List";

        Suppliers = db.Suppliers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName);

    }
}