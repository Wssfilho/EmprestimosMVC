using System.Linq;
using LivrosEmprestimos.Data;
using LivrosEmprestimos.Models;
using Microsoft.AspNetCore.Mvc;
using LivrosEmprestimos.Repository.Contracts;

namespace LivrosEmprestimos.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _emprestimo;

        public EmprestimoController(IEmprestimoRepository emprestimo)
        {
            _emprestimo = emprestimo;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = (IEnumerable<EmprestimosModel>)_emprestimo.GetAll();
            return View(emprestimos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            EmprestimosModel emprestimos = _emprestimo.GetId(id);

            return View(emprestimos);
        }
        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if(_emprestimo.Cadastrar(emprestimos) != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {
            if (_emprestimo.Editar(emprestimo) != null)
            {
                return RedirectToAction("Index");
            }

            return View(emprestimo);
        }
        [HttpGet]
        public IActionResult Excluir(int? id) {

            EmprestimosModel emprestimos = _emprestimo.GetId(id);
            return View(emprestimos);
        }
        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
          if(_emprestimo.Excluir(emprestimo) != null)
            {
                return RedirectToAction("Index");
            }
            return View(emprestimo);

        }

    }
}
