using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Pontuacao_Basquete_DataAcess.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
