using AplicativoWebCadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoWebCadastro.Controllers
{
    public class CepController : Controller
    {
        private readonly ILogger<CepController> _logger;

        public CepController(ILogger<CepController> logger)
        {
            _logger = logger;
        }

        public IActionResult CepIndex()
        {
            string empty = string.Empty;
            ViewBag.Cep = Business.CepModel.Busca(empty);
            return View();
        }

        public string Consulta(string cep)
        {
            var cepObj = Business.CepModel.Busca(cep);
            return new JavaScriptSerializer().Serialize(cepObj);
        }
    }
}
