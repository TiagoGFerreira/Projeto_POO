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
    public interface IPessoa
    {
        int GetIdade(DateTime DataNasc);
    }

    [Serializable]
    public abstract class PessoaBase : IPessoa
    {
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
