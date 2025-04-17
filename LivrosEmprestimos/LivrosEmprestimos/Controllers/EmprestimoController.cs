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
            IEnumerable<EmprestimosModel> emprestimos = _context.Emprestimos.ToList();
            return View(emprestimos);
        }
    }
}
