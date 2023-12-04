/*
 * Classe Exames
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using System.Linq;
using Objetos;

namespace ServicosDLL
{
    public static class Exames
    {
        /// <summary>
        /// Classe Exames
        /// </summary>
        #region ATRIBUTOS

        private static List<Exame> exames = new List<Exame>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Exame , Exames
        /// </summary>
        public static List<Exame> ListadeExames
        {
            get
            {
                return exames;
            }
            set
            {
                exames = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar um exame na lista de exames
        /// </summary>

        public static void AdicionarExame(Exame exame)
        {
            exames.Add(exame);
        }



        /// <summary>
        /// Método para remover um exame na lista de exames
        /// </summary>

        public static void RemoverExame(Exame exame)
        {
            exames.Remove(exame);
        }

        /// <summary>
        /// Método que retorna em lista todos os exames feitos pelo paciente
        /// Método interno para poder ser acedido apenas dentro do mesmo assembly
        /// Ainda em desenvolvimento
        /// </summary>
        public static List<Exame> ObterExamesPorPaciente(int nus)
        {
            return exames.Where(exame => exame.nus == nus).ToList();
        }

        #endregion
        #endregion
    }
}
