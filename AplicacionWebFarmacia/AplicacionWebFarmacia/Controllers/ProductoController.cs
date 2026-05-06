using AplicacionWebFarmacia.Models;
using Microsoft.AspNetCore.Mvc;


namespace AplicacionWebFarmacia.Controllers
{
    public class ProductoController : Controller
    {
        List<Producto> listaProductos = new List<Producto>() {
            new Producto(1, "Jarabe", DateTime.Parse("2026-04-30"),20,5000),
            new Producto(2, "Paracetamol", DateTime.Parse("2026-02-02"),50,2000),
            new Producto (3, "Alflorex", DateTime.Parse("2026-03-01"),30,1200),
            new Producto (4, "Gastrezol", DateTime.Parse("2025-09-25"),30,3000),
            new Producto(5, "Vivera", DateTime.Parse("2025-09-12"),20,1500),
            new Producto(6, "Ozempic", DateTime.Parse("2025-12-01"),60,2650),
            new Producto(7, "Keval Eletriptan", DateTime.Parse("2025-06-25"),15,3000),
            new Producto(8, "Artrosome", DateTime.Parse("2025-08-16"),30,2700),
            new Producto(9, "Arthrozeel", DateTime.Parse("2024-01-01"),56, 1250),
            new Producto(10, "Biosul", DateTime.Parse("2023-05-03"),29,2300)
            };
        public IActionResult IndexProductos()
        {
            return View(listaProductos);
        }
    }
}
