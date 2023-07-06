using SistemaEmprestimo.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaEmprestimo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
