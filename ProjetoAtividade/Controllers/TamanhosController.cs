using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Controllers
{
    public class TamanhosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }
        public IActionResult ConfirmarDeletar()
        {
            return View();
        }
    }
}
