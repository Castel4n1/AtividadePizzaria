using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Criar() 
        {
                DadosDropdown();
                return View();
        }
        [HttpPost]
        public IActionResult Criar(PostPizzasDTO pizzasDTO)
        {
            if (!ModelState.IsValid)
            {
                DadosDropdown();
                return View();
            }
            
            Pizza pizza = new Pizza
                (
                    pizzasDTO.Nome, 
                    pizzasDTO.Preco, 
                    pizzasDTO.FotoUrl, 
                    pizzasDTO.TamanhoId
                );

            _context.Pizzas.Add(pizza);
            _context.SaveChanges();

            //Relacionamento
            foreach (var saborId in pizzasDTO.SaboresId) 
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
                return View("NotFound");

            var resultado = _context.Pizzas
                .Include(p => p.PizzaSabores)
                .ThenInclude(p => p.Sabor)
                .FirstOrDefault(p => p.Id == id);

            if (resultado == null)
                return View("NotFound");

            var rest = new PostPizzasDTO()
            {
                Nome = resultado.Nome,
                FotoUrl = resultado.FotoUrl,
                Preco = resultado.Preco,
                TamanhoId = resultado.TamanhoId,
                SaboresId = resultado.PizzaSabores.Select(ps => ps.SaborId).ToList()

            };

            DadosDropdown();
            return View(rest);
        }
        [HttpPost, ActionName("Atualizar")]
        public IActionResult Atualizar(int id, PostPizzasDTO pizzasDTO)
        {
            var resultado = _context.Pizzas.FirstOrDefault(p => p.Id == id);

            if (!ModelState.IsValid)
            {
                DadosDropdown();
                return View(resultado); 
            }

            resultado.AtualizarDados
                (
                pizzasDTO.Nome, 
                pizzasDTO.FotoUrl, 
                pizzasDTO.Preco, 
                pizzasDTO.TamanhoId
                );

            _context.Update(resultado);
            _context.SaveChanges();

            //Relacionamento Atualizar Sabor

            var pizzasSaboresAtual = _context.PizzaSabores.Where(ps => ps.PizzaId == resultado.Id);
            _context.PizzaSabores.RemoveRange(pizzasSaboresAtual);
            _context.SaveChanges();

            foreach (var saborId in pizzasDTO.SaboresId)
            {
                var novoSabor = new PizzaSabor(resultado.Id, saborId);
                _context.PizzaSabores.Add(novoSabor);
                _context.SaveChanges();
            }

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
        public void DadosDropdown()
        {
            var viewbag = new PostPizzaDropdown()
            {
                Sabores = _context.Sabores.OrderBy(s => s.Nome).ToList(),
                Tamanhos = _context.Tamanhos.OrderBy(t => t.Nome).ToList()
            };

            ViewBag.Sabores = new SelectList(viewbag.Sabores, "Id", "Nome");
            ViewBag.Tamanhos = new SelectList(viewbag.Tamanhos, "Id", "Nome");
        }
    
    }
}
