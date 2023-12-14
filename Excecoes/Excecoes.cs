/*
 * Classe Exçecões
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 10-11-2023
 * POO-LESI
 */

using System;

namespace Excecoes
{
    public class DataInvalidaException : Exception
    {
        public DataInvalidaException() : base("Data de nascimento incorreta")
        {
        }

        public DataInvalidaException(string message) : base(message)
        {
        }

        public DataInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class ArgumentoNuloException : Exception
    {
        public ArgumentoNuloException() : base("Argumento nulo")
        {
        }

        public ArgumentoNuloException(string message) : base(message)
        {
        }
    }

    public class SexoInvalidoException : Exception
    {
        public SexoInvalidoException() : base("Sexo deve ser Masculino ou Feminino")
        {
        }

        public SexoInvalidoException(string message) : base(message)
        {
        }
    }

    public class NUSException : Exception
    {
        public NUSException() : base("O NR Utente de saude nao e valido")
        {
        }

        public NUSException(string message) : base(message)
        {
        }
    }

    public class IDException : Exception
    {
        public IDException() : base("O id nao e valido")
        {
        }

        public IDException(string message) : base(message)
        {
        }
    }
}

