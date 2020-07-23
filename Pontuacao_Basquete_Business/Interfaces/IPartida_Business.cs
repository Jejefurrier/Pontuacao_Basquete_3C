using Pontuacao_Basquete_Common;
using Pontuacao_Basquete_Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pontuacao_Basquete_Business.Interfaces
{
    public interface IPartida_Business
    {
        IResultBag AddPartida(Partida partida);
        IResultBag GetPartidas();
    }
}
