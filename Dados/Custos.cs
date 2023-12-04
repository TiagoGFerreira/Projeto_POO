/*
 * Classe Custos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */
using System.Collections.Generic;
using Objetos;

namespace Dados
{
    public static class Custos
    {
        /// <summary>
        /// Classe Custos
        /// </summary>
        #region ATRIBUTOS

        private static List<Custo> custos = new List<Custo>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Custo , Custos
        /// </summary>
        public static List<Custo> ListadeCustos
        {
            get
            {
                return custos;
            }
            set
            {
                custos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar um custo na lista de custos
        /// </summary>

        public static void AdicionarCusto(Custo custo)
        {
            custos.Add(custo);
        }



        /// <summary>
        /// Método para remover um custo na lista de custos
        /// </summary>

        public static void RemoverCusto(Custo custo)
        {
            custos.Remove(custo);
        }
        #endregion
        #endregion
    }
}
