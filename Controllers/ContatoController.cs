using Microsoft.AspNetCore.Mvc;
using SistemaDeContatos.Data;

namespace SistemaDeContatos.Controllers
{
    public class ContatoController : Controller
    {


        readonly private ApplicationDbContext _db;

        public IActionResult Index()
        {
            return View();
        }
    }
}
