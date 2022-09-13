using System.Diagnostics;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //private readonly Helper _helper = new Helper();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> form(string type, string product, int price)
    {
        //_helper.initialize();
        FirestoreDb db = FirestoreDb.Create("g-cloud-university");
        var mybudget = new Budget { Type = type, Product = product, Price = price };
        var docs = db.Collection("budgets").Document(type);
        await docs.SetAsync(mybudget);
        return Index();
    }

    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

