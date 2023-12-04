/*
 * Classe Internamentos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using Objetos;

namespace Dados
{
    public static class Internamentos
    {
        /// <summary>
        /// Classe Internamentos
        /// </summary>
        #region ATRIBUTOS

        private static List<Internamento> internamentos = new List<Internamento>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Internamento , Internamento
        /// </summary>
        public static List<Internamento> ListadeInternamentos
        {
            get
            {
                return internamentos;
            }
            set
            {
                internamentos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar um internamento na lista de internamentos
        /// </summary>

        public static void AdicionarInternamento(Internamento internamento)
        {
            internamentos.Add(internamento);
        }



        /// <summary>
        /// Método para remover um internamento na lista de internamentos
        /// </summary>

        public static void RemoverInternamento(Internamento internamento)
        {
            internamentos.Remove(internamento);
        }
        #endregion
        #endregion
    }
}
