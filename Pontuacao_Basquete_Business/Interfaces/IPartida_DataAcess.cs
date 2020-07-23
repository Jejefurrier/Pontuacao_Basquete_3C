using Pontuacao_Basquete_Business;
using Pontuacao_Basquete_Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pontuacao_Basquete_DataAcess.Interfaces
{
    public interface IPartida_DataAcess
    {
        IResultBag AddPartida(Partida partida);
        IResultBag GetPartidas();
    }
}
