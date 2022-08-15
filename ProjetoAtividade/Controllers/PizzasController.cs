using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAtividade.Data;
using ProjetoAtividade.Models;
using ProjetoAtividade.Models.ViewModels.RequestDTO;
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
        [HttpPost]
        public IActionResult Criar(PostPizzasDTO pizzasDTO)
        {
            if (!ModelState.IsValid) return View(pizzasDTO);
            Pizza pizza = new Pizza(pizzasDTO.Nome, pizzasDTO.Preco, pizzasDTO.FotoUrl);

            _context.Pizzas.Add(pizza);
            _context.SaveChanges();

            foreach (var saborId in pizzasDTO.SaborId)
            {
                var novoSabor = new PizzaSabor(pizza.Id, saborId);
                _context.PizzaSabores.Add(novoSabor);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int? id)
        {
            if (id == null)
                return NotFound();

            var resultado = _context.Pizzas
                .Include(p => p.PizzaSabores).ThenInclude(p => p.Sabor).FirstOrDefault(p => p.Id == id);

            if (resultado == null)
                return View();

            return View(resultado);
        }
        [HttpPost]
        public IActionResult Atualizar(int id, PostPizzasDTO pizzasDTO)
        {
            var resultado = _context.Pizzas.FirstOrDefault(p => p.Id == id);

            if(!ModelState.IsValid) return View(resultado);

            resultado.AtualizarDados(pizzasDTO.Nome, pizzasDTO.FotoUrl, pizzasDTO.Preco);

            _context.Update(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Detalhes), resultado);
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
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var resultado = _context.Pizzas.FirstOrDefault(p => p.Id == id);

            _context.Remove(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
