using Microsoft.AspNetCore.Mvc;
using ProjetoAtividade.Data;
using ProjetoAtividade.Models;
using ProjetoAtividade.Models.ViewModels.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Controllers
{
    public class SaboresController : Controller
    {
        private PizzariaDbContext _context;

        public SaboresController(PizzariaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() => View(_context.Sabores);

        public IActionResult Detalhes(int id) => View(_context.Sabores.Find(id));

        public IActionResult Criar() => View();
        [HttpPost]
        public IActionResult Criar(PostSaboresDTO SaboresDTO)
        {
            if (ModelState.IsValid) return View();
            Sabor saborT = new Sabor(SaboresDTO.Nome);
            _context.Add(saborT);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Atualizar(int? id)
        {
            if (id == null) return View("not found");

            var resultado = _context.Sabores.FirstOrDefault(s => s.SaborId == id);

            if (id == null) return View();

            return View(resultado);
        }
        [HttpPost]
        public IActionResult Atualizar (int id, PostSaboresDTO saboresDTO)
        {
            var resultado = _context.Sabores.FirstOrDefault(s => s.SaborId == id);
            if(ModelState.IsValid) return View(resultado);

            resultado.AtualizarDados(saboresDTO.Nome, saboresDTO.FotoUrl, saboresDTO.Preco);
            _context.Sabores.Update(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var resultado = _context.Sabores.FirstOrDefault(s => s.SaborId == id);
            if (resultado == null) return View();

            return View(resultado);
        }
        [HttpPost]
        public IActionResult ConfirmarDeletar(int id)
        {
            var resultado = _context.Sabores.FirstOrDefault(s => s.SaborId == id);
            _context.Sabores.Remove(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
