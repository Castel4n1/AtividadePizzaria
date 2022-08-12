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
    }
}
