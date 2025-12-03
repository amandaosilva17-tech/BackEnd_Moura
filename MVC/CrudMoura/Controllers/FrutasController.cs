using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    
    public class Frutas : Controller
    {
        private readonly ILogger<Frutas> _logger;

        public List <Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Morango", Preco = 5.99F, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ Id = 1, Nome = "Abacate", Preco = 5.99F, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ Id = 1, Nome = "Limão", Preco = 5.99F, Quantidade = 100, Categoria = "Citrica"},
        };

        public Frutas(ILogger<Frutas> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            ListaDeFrutas
        }


        public IActionResult ListarFrutas()
        {
            ViewBag.sacolinha = ListaDeFrutas; 
            return View();
        }
        
        public IActionResult Create()
        {
            
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}