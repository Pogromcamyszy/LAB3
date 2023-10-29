using Microsoft.AspNetCore.Mvc;
using LAB3.Models;

namespace LAB3.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane) 
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
