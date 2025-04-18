using LivrosEmprestimos.Data;
using LivrosEmprestimos.Models;
using LivrosEmprestimos.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace LivrosEmprestimos.Repository
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly ApplicationDbContext _context;
        public EmprestimoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
       

        public EmprestimosModel Cadastrar(EmprestimosModel emprestimos)
        {
           if(emprestimos == null)
            {

                return null;  
                   
            }
            _context.Emprestimos.Add(emprestimos);
            _context.SaveChanges();
            return emprestimos;
        }

       

        public EmprestimosModel Editar(EmprestimosModel emprestimo)
        {
            if(emprestimo == null)
            {
                return null;
            }
            _context.Emprestimos.Update(emprestimo);
            _context.SaveChanges();
            return emprestimo;
        }
        

       

        public EmprestimosModel Excluir(EmprestimosModel emprestimos)
        {
            if (emprestimos == null)
            {
                return null;
            }
            _context.Emprestimos.Remove(emprestimos);
            _context.SaveChanges();
            return emprestimos;
        }

        public IEnumerable<EmprestimosModel> GetAll()
        {
            IEnumerable<EmprestimosModel> emprestimos = _context.Emprestimos;
            return emprestimos;
        }

        public EmprestimosModel GetId(int? id)
        {
            if (id == 0 || id == null)
            {
                return null;
            }
            EmprestimosModel emprestimos = _context.Emprestimos.FirstOrDefault(x => x.Id == id);
            return emprestimos; // Ensure a return statement is present in all code paths
        }

        
    }
}
