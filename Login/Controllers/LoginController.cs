﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Entrar(string usuario, string senha)
        {
            if(usuario =="admin"&& senha == "123")
            {
                return View(1);
            }
            else
            {
                return View(2);
            }
            
        }

        public IActionResult FalhaLogin()
        {
            return View();
        }
    }
}
