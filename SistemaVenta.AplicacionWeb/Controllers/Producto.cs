using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class Producto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
