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
    #region Data Invalida
    public class DataInvalidaException : Exception
    {
        public DataInvalidaException() : base("Data de nascimento incorreta") { }

        public DataInvalidaException(string message) : base(message) { }

        public DataInvalidaException(string message, Exception innerException) : base(message, innerException) { }
    }
    #endregion

    #region Argumento Nulo
    public class ArgumentoNuloException : Exception
    {
        public ArgumentoNuloException() : base("Argumento nulo") { }

        public ArgumentoNuloException(string message) : base(message) { }
    }

    #endregion

    #region SexoInvalido
    public class SexoInvalidoException : Exception
    {
        public SexoInvalidoException() : base("Sexo deve ser Masculino ou Feminino") { }

        public SexoInvalidoException(string message) : base(message) { }
    }
    #endregion

    #region NR de Utente
    public class NUSException : Exception
    {
        public NUSException() : base("O NR Utente de saude nao e valido") { }

        public NUSException(string message) : base(message) { }
    }
    #endregion

    #region ID
    public class IDException : Exception
    {
        public IDException() : base("O id nao e valido") { }

        public IDException(string message) : base(message) { }
    }
    #endregion

    #region Cama Vazia
    public class CamaVaziaException : Exception
    {
        public CamaVaziaException() : base("Nao existe camas desocupadas") { }

        public CamaVaziaException(string message) : base(message) { }
    }
    #endregion

    #region Verifica se Existe
    public class ExisteException : Exception
    {
        public ExisteException() : base("Nao existe camas desocupadas") { }

        public ExisteException(string message) : base(message) { }
    }
    #endregion

    #region Custo
    public class CustoException : Exception
    {
        public CustoException() : base("Nao foi possivel calcular o custo") { }

        public CustoException(string message) : base(message) { }
    }
    #endregion
}