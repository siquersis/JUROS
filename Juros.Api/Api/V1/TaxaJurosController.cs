using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Juros.Api.Api.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("taxaJuros")]
        public double TaxaJuros()
        {
            double taxa = 0.01;

            return taxa;
        }
    }
}
