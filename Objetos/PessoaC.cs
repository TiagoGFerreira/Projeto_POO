/*
 * Classe Abstrata de Pessoa e Interface de Pessoa
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 08-12-2023
 * POO-LESI
 */

using System;

namespace Objetos
{
    /// <summary>
    /// Interface IPessoa
    /// </summary>
    public interface IPessoa
    {
        int GetIdade(DateTime DataNasc);
    }


    /// <summary>
    /// Classe abstrata PessoaBase que herda da interface IPessoa
    /// </summary>
    [Serializable]
    public abstract class PessoaBase : IPessoa
    {
        /// <summary>
        /// Metodo GetIdade que de acordo com a Data de Nascimento calcula a idade que ele tem
        /// </summary>
        public int GetIdade(DateTime DataNasc)
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNasc.Year;

            if (DataNasc.Date > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }
    }
}
