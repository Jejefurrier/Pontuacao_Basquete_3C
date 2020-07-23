using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pontuacao_Basquete_Business;
using Pontuacao_Basquete_Business.Interfaces;

namespace Pontuacao_Basquete.Controllers
{
    [Route("api/[controller]")]
    public class PontuacaoController : Controller
    {
        private readonly IPartida_Business _partida;
        public PontuacaoController(IPartida_Business partida)
        {
            _partida = partida;
        }
        [HttpGet]
        [Route("getjogos")]
        public IActionResult GetJogos()
        {
            var resultado = _partida.GetPartidas();
            if (resultado.IsSuccess)
            {
                return Ok(resultado);
            }
            return BadRequest(resultado.Message);
        }

        [HttpPost]
        [Route("postjogos")]
        public IActionResult PostJogos([FromBody] Partida partida)
        {
            var resultado = _partida.AddPartida(partida);
            if (resultado.IsSuccess)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest(resultado.Message);
            }
        }
    }
}
