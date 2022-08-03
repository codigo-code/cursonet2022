using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clase1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clase1.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult validar(User user)
        {
                    

            return View(user); // redirection
        }
    }
}

