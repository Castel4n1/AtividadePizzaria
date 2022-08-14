using Microsoft.AspNetCore.Mvc;
using ProjetoAtividade.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Controllers
{
    public class SaboresController : Controller
    {
        private SaboresController _context;

        public SaboresController(SaboresController context)
        {
            _context = context;
        }
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
