﻿using Microsoft.AspNetCore.Mvc;
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
    public class TamanhosController : Controller
    {
        private PizzariaDbContext _context;

        public TamanhosController(PizzariaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() => View(_context.Tamanhos);

        public IActionResult Detalhes(int id) 
        {
            var resultado = _context.Tamanhos
            .Include(af => af.Pizzas)
            .FirstOrDefault(tamanho => tamanho.Id == id);

            if (resultado == null)
                return View("NotFound");

            return View(resultado);
        }

        public IActionResult Criar() => View();
        [HttpPost]
        public IActionResult Criar(PostTamanhosDTO tamanhoDTO)
        {
            if (!ModelState.IsValid) return View();

            Tamanho tamanho = new (tamanhoDTO.Nome);
            _context.Add(tamanho);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Atualizar(int? id)
        {
            if (id == null) return View("not found");

            var resultado = _context.Tamanhos.FirstOrDefault(t => t.Id == id);

            if (id == null) return View();

            return View(resultado);
        }
        [HttpPost]
        public IActionResult Atualizar(int id, PostTamanhosDTO tamanhoDTO)
        {
            var resultado = _context.Tamanhos.FirstOrDefault(t => t.Id == id);
            if (!ModelState.IsValid) return View(resultado);

            resultado.AtualizarDados(tamanhoDTO.Nome);
            _context.Tamanhos.Update(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var resultado = _context.Tamanhos.FirstOrDefault(t => t.Id == id);
            if (resultado == null) return View();

            return View(resultado);
        }
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var resultado = _context.Tamanhos.FirstOrDefault(t => t.Id == id);
            _context.Tamanhos.Remove(resultado);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
