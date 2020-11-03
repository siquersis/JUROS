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
        private readonly ITaxaJuros _taxaJuros;

        public ResultadoCalduloJurosController(ILogger<ResultadoCalduloJurosController> logger, ITaxaJuros taxaJuros)
        {
            _logger = logger;
            _taxaJuros = taxaJuros;
        }

        /// <summary>
        /// Retorna o calculo dos Juros consumindo a API 1.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("calculaJuros")]
        public void CalculaJuros(decimal valorInicial,int tempo, TaxaJuros taxa)
        { 
            var juros = Convert.ToDecimal(valorInicial);
            var taxaDeJuros = Convert.ToDecimal(taxa);
            //Valor Final = Valor Inicial * (1 + juros) ^ Tempo

            //var valorFinal = valorInicial * 1 + juros * Math.Pow(tempo / 12);
        }
    }
}
