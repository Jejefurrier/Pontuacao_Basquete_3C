using System;
using System.Collections.Generic;
using System.Text;

namespace Pontuacao_Basquete_Common.Interfaces
{
    public interface IResultBag
    {
        string Message { get; }
        bool IsSuccess { get; }
    }

    public interface IResultBag<T> : IResultBag
    {
        T Data { get; }
    }
}
