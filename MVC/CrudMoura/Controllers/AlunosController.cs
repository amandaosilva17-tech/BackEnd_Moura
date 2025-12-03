using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Models
{
    [Route("[controller]")]
    public class CrudMoura : Controller
    {
        private readonly ILogger<AlunosController> _logger;

        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public static List<Aluno> ListaDeAlunos = new List<Aluno>

        new Aluno {Id = 1, Nome = "Amanda"}

        //  new Fruta{ Id = 1, Nome = "Morango", Preco = 5.99F, Quantidade = 10, Categoria = "Tropical"},
        //     new Fruta{ Id = 1, Nome = "Abacate", Preco = 5.99F, Quantidade = 12, Categoria = "Tropical"},
        //     new Fruta{ Id = 1, Nome = "Limão", Preco = 5.99F, Quantidade = 100, Categoria = "Citrica"},



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listar()
        {
            return View();
        }   
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Editar()
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