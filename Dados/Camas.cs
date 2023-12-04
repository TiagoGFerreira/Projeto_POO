/*
 * Classe Camas
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using System.Linq;
using Objetos;

namespace Dados
{
    public static class Camas
    {
        /// <summary>
        /// Classe Camas
        /// </summary>
        #region ATRIBUTOS

        private static List<Cama> camas = new List<Cama>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Cama , Camas
        /// </summary>
        public static List<Cama> ListadeCamas
        {
            get
            {
                return camas;
            }
            set
            {
                camas = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma cama da lista de camas
        /// </summary>

        public static void AdicionarCama(Cama cama)
        {
            camas.Add(cama);
        }



        /// <summary>
        /// Método para remover uma cama da lista de camas
        /// </summary>

        public static void RemoverCama(Cama cama)
        {
            camas.Remove(cama);
        }

        /// <summary>
        /// Método que retorna uma lista estática das camas que estão ocupadas
        /// </summary>
        public static List<Cama> CamasOcupadas()
        {
            return camas.Where(c => c.ObterEstado()).ToList();
        }


        /// <summary>
        /// Método que retorna uma lista estática das camas que estão desocupadas
        /// </summary>
        public static List<Cama> CamasDesocupadas()
        {

            return camas.Where(c => !c.ObterEstado()).ToList();
        }
        #endregion
        #endregion
    }
}
