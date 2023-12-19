/*
 * Classe Diagnósticos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using Objetos;
using Excecoes;

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

        /// <summary>
        /// Método para retornar a lista de diagnosticos
        /// </summary>
        public static List<Diagnostico> ListaDiagnosticos()
        {
            return diagnosticos;
        }

        /// <summary>
        /// Método que obtem a lista de diagnosticos que o paciente fez numa certa data
        /// </summary>
        public static List<Diagnostico> ListaPaciente(int nus, DateTime dataInicio, DateTime dataFim)
        {
            List<Diagnostico> i = new List<Diagnostico>();
            foreach (Diagnostico diagnostico in diagnosticos)
            {
                if(dataFim <= dataInicio)
                {
                    throw new DataInvalidaException("Data invalida");
                }
                if (diagnostico.nus == nus)
                {
                    i.Add(diagnostico);
                }
            }
            return i;
        }
        #endregion
        #endregion
    }
}
