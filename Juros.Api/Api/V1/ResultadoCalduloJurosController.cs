using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Juros.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Juros.Api.Api.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoCalduloJurosController : ControllerBase
    {
        private readonly ILogger<ResultadoCalduloJurosController> _logger;

        public ResultadoCalduloJurosController(ILogger<ResultadoCalduloJurosController> logger)
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

        [HttpGet]
        [Route("calculaJuros")]
        public async Task<HttpResponse> CalculaJuros(decimal valorInicial,int tempo)
        { 
            var juros = Convert.ToDecimal(TaxaJuros());
            //Valor Final = Valor Inicial * (1 + juros) ^ Tempo

            //var valorFinal = valorInicial * 1 + juros * Math.Pow(tempo / 12);

            //return await this.Create(valorFinal);
        }
    }
}
