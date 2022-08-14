using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAtividade.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Controllers
{
    public class PizzasController : Controller
    {
        private PizzariaDbContext _context;

        public PizzasController(PizzariaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Pizzas);
        }

        public IActionResult Criar() => View();

        public IActionResult Atualizar(int? id)
        {
            if (id == null)
                return NotFound();

            var resultado = _context.Pizzas.FirstOrDefault(p => p.Id == id);

            if (resultado == null)
                return View();

            return View(resultado);
        }

        public IActionResult Detalhes(int id)
        {
            var resultado = _context.Pizzas
                .Include(ps => ps.PizzaSabores)
                .ThenInclude(s => s.Sabor)
                .FirstOrDefault(pizza => pizza.Id == id);

            if (resultado == null) 
                return View("NotFound");

            return View(resultado);
        }

        public IActionResult Deletar(int id)
        {
            var resultado = _context.Pizzas.FirstOrDefault(p => p.Id == id);
            if (resultado == null) return View();
            return View(resultado);
        }
        [HttpPost]
        public IActionResult ConfirmarDeletar()
        {
            return View();
        }
    }
}
