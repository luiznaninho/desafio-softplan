using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftplan.API_2.Controllers
{
    [Route("")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("calculaJuros")]
        public ActionResult<double> Get(double valorInicial, int meses)
        {
            return valorInicial * meses;
        }

        [HttpGet]
        [Route("showmethecode")]
        public ActionResult<string> ShowMeTheCode()
        {
            return "https://github.com/luiznaninho/desafio-softplan";
        }
    }
}
