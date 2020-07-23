using Dapper;
using Pontuacao_Basquete_Business;
using Pontuacao_Basquete_DataAcess.Interfaces;
using SqlKata.Compilers;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System.Linq;
using Pontuacao_Basquete_Common.Interfaces;
using Pontuacao_Basquete_Common;
using Pontuacao_Basquete_Business.Interfaces;

namespace Pontuacao_Basquete_DataAcess
{
    public class Partida_DataAcess : IPartida_DataAcess
    {
        private readonly IConnectionFactory _conn;
        public Partida_DataAcess(IConnectionFactory conn)
        {
            _conn = conn;
        }
        public IResultBag AddPartida(Partida partida)
        {
            try
            {
                using (var connection = _conn.Connection())
                {
                    connection.Open();
                    connection.ExecuteAsync("INSERT INTO Pontuacao(Pontos, Dia) VALUES(@Pontos, @Dia)", partida);
                    //connection.Query($"");
                    return new ResultBag("Adicionado com sucesso!", true);
                }
            }
            catch (Exception ex)
            {

                return new ResultBag(ex.Message, false);
            }
        }

        public IResultBag GetPartidas()
        {
            try
            {
                using (var connection = _conn.Connection())
                {
                    return new ResultBag<IEnumerable<Partida>>("Aqui estão os resultados das suas partidas"  , true,  connection.Query<Partida>("SELECT * FROM Pontuacao"));
                }
            }
            catch (Exception ex)
            {

                return new ResultBag(ex.Message, false);
            }
        }
    }
}
