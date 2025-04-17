using LivrosEmprestimos.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrosEmprestimos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    } 
}
