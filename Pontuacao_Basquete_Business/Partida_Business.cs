using Pontuacao_Basquete_Business.Interfaces;
using Pontuacao_Basquete_Common;
using Pontuacao_Basquete_DataAcess;
using System;
using System.Collections.Generic;
using System.Text;
using Pontuacao_Basquete_DataAcess.Interfaces;
using Pontuacao_Basquete_Common.Interfaces;
using Pontuacao_Basquete_Business.Validations;

namespace Pontuacao_Basquete_Business
{
    public class Partida_Business : IPartida_Business
    {
        private readonly IPartida_DataAcess _partida;
        public Partida_Business(IPartida_DataAcess partida)
        {
            _partida = partida;
        }

        public IResultBag AddPartida(Partida partida)
        {
            PartidaValidation validador = new PartidaValidation();
            var resultValidation = validador.Validate(partida);
            if(resultValidation.IsValid)
            {
                return _partida.AddPartida(partida);
            }
            else
            {
                return new ResultBag(string.Join(", ", resultValidation.Errors), false);
            }
        }

        public IResultBag GetPartidas()
        {
            return _partida.GetPartidas();
        }
    }
}
