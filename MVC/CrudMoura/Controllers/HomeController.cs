using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //ação padrão inicial 

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        //retorna a pagina MinhaAcao.csthml
        return View();
    }

    public IActionResult ListarNomes()
    {
        //cria um arryay de nomes ja preenchido
        string[] nomes = {"Nikki", "Isabella", "Ariana", "Rafael"};
        ViewBag.Teste = "Olá, eu vim pela ViewBag";
        ViewBag.nomes = nomes = nomes;//guarda os nomes na viewbag

        return View();
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
