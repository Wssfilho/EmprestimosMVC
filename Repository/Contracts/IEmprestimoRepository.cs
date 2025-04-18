namespace LivrosEmprestimos.Repository.Contracts;
using LivrosEmprestimos.Models;
using Microsoft.AspNetCore.Mvc;

public interface IEmprestimoRepository
    {
    public EmprestimosModel Cadastrar(EmprestimosModel emprestimos);
    public EmprestimosModel GetId(int? id);
    public EmprestimosModel Editar(EmprestimosModel emprestimos);
    public EmprestimosModel Excluir(EmprestimosModel emprestimos);
    public IEnumerable<EmprestimosModel> GetAll();
}
    
   
