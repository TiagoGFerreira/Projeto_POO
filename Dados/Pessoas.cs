/*
 * Classe Pessoas
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Objetos;

namespace Dados
{
    public static class Pessoas
    {
        /// <summary>
        /// Classe Pessoas
        /// </summary>
        #region ATRIBUTOS

        private static List<Pessoa> pessoas = new List<Pessoa>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Pessoa , Pessoas
        /// </summary>
        public static List<Pessoa> ListadePessoas
        {
            get
            {
                return pessoas;
            }
            set
            {
                pessoas = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma pessoa da lista de pessoas
        /// </summary>

        public static void AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }



        /// <summary>
        /// Método para remover uma pessoa da lista de pessoas
        /// </summary>

        public static void RemoverPessoa(Pessoa pessoa)
        {
            pessoas.Remove(pessoa);
        }

        /// <summary>
        /// Método para obter a lista Pessoas
        /// </summary>
        public static List<Pessoa> ListaPessoas()
        {
            return pessoas;
        }

        public static bool PessoaExiste(Pessoa p)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == p.Nome && pessoa.DataNasc == p.DataNasc && pessoa.Sexo == p.Sexo)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
        #endregion
    }
}