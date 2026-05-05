using AplicacionWebFarmacia.Models;
using Microsoft.AspNetCore.Mvc;


namespace AplicacionWebFarmacia.Controllers
{
    public class ProductoController : Controller
    {
        List<Producto> listaProductos = new List<Producto>() {
            new Producto(1, "Jarabe", DateTime.Parse("2026-04-30"),20,5000),
            new Producto(2, "Paracetamol", DateTime.Parse("2026-02-02"),50,2000)
            };
        public IActionResult Index()
        {
            return View(listaProductos);
        }
    }
}
