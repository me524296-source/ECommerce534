using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce534.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext context = new ApplicationDbContext();
    public IActionResult Index()
    {
        //filter
        var products=context
            .Products
            .Include(p => p.Category)
            .AsQueryable();
        //products = products.Where(e=>e.Id >= 5);

        //foreach (var item in products)
        //{
        //    Console.WriteLine($"Id :{item.Id}  , Name :{item.Name}");
        //}

        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public ViewResult Welcome()
    {
       return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
