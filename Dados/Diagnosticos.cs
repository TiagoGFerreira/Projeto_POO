/*
 * Classe Diagnósticos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using Objetos;

namespace Dados
{
    public static class Diagnosticos
    {
        /// <summary>
        /// Classe Diagnósticos
        /// </summary>
        #region ATRIBUTOS

        private static List<Diagnostico> diagnosticos = new List<Diagnostico>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Diagnóstico , Diagnósticos
        /// </summary>
        public static List<Diagnostico> ListadeDiagnosticos
        {
            get
            {
                return diagnosticos;
            }
            set
            {
                diagnosticos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar um diagnostico na lista de diagnosticos
        /// </summary>

        public static void AdicionarDiagnostico(Diagnostico diagnostico)
        {
            diagnosticos.Add(diagnostico);
        }



        /// <summary>
        /// Método para remover um diagnostico na lista de diagnosticos
        /// </summary>

        public static void RemoverDiagnostico(Diagnostico diagnostico)
        {
            diagnosticos.Remove(diagnostico);
        }
        #endregion
        #endregion
    }
}
