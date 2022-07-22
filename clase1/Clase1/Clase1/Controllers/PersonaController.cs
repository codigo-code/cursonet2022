using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clase1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clase1.Controllers
{
    public class PersonaController : Controller
    {
      
        public IActionResult Index()
        {
            Persona p = new Persona();

            p.nombre = "Dante";
            return View(p); // DataBinding <----  del controlador a la vista ...> le pasamos el obj p a la vista
        } 

        public IActionResult Modificar()
        {
           
            return View();
        }
    }
}

