using Microsoft.AspNetCore.Mvc;
using SistemaEmprestimo.Data;
using SistemaEmprestimo.Models;

namespace SistemaEmprestimo.Controllers
{
    public class EmprestimoController : Controller
    {

        private ApplicationDbContext _db;

        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
    }
}
