using Pontuacao_Basquete_Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pontuacao_Basquete_Common
{
    public class ResultBag : IResultBag
    {
        public string Message { get; }
        public bool IsSuccess { get; }

        public ResultBag(bool isSuccess)
        {
            Message = string.Empty;
            IsSuccess = isSuccess;
        }

        public ResultBag(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
    }

    public class ResultBag<T> : IResultBag<T>
    {
        public string Message { get; }
        public bool IsSuccess { get; }

        public T Data { get; }

        public ResultBag(bool isSuccess, T data)
        {
            Message = string.Empty;
            IsSuccess = isSuccess;
            Data = data;
        }

        public ResultBag(string message, bool isSuccess, T data)
        {
            Message = message;
            IsSuccess = isSuccess;
            Data = data;
        }
    }
}
