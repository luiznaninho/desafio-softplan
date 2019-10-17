using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftplan.API_1.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<decimal> Get()
        {
            return 0.01M;
        }
    }
}
