using System.Linq;
using LivrosEmprestimos.Data;
using LivrosEmprestimos.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrosEmprestimos.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmprestimoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _context.Emprestimos;
            return View(emprestimos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            EmprestimosModel emprestimos = _context.Emprestimos.FirstOrDefault(x => x.Id == id);
            if(emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }
        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if(ModelState.IsValid)
            {
                _context.Emprestimos.Add(emprestimos);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _context.Emprestimos.Update(emprestimo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emprestimo);
        }
        [HttpGet]
        public IActionResult Excluir(int? id) {

            if (id == 0 || id == null)
            {
                return NotFound();
            }
            EmprestimosModel emprestimos = _context.Emprestimos.FirstOrDefault(x => x.Id == id);
            if (emprestimos == null)
            {
                return NotFound();
            }
            return View(emprestimos);
        }
        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
          if(emprestimo == null)
            {
                return NotFound();
            }
            else
            {
                _context.Emprestimos.Remove(emprestimo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}
