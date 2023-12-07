/*
 * Classe Consultas
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using Objetos;

namespace Dados
{
    public static class Consultas
    {
        /// <summary>
        /// Classe Consultas
        /// </summary>
        #region ATRIBUTOS

        private static List<Consulta> consultas = new List<Consulta>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Consulta , Consultas
        /// </summary>
        public static List<Consulta> ListadeConsultas
        {
            get
            {
                return consultas;
            }
            set
            {
                consultas = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma consulta na lista de consultas
        /// </summary>

        public static void AdicionarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }



        /// <summary>
        /// Método para remover uma consulta na lista de consultas
        /// </summary>

        public static void RemoverConsulta(Consulta consulta)
        {
            consultas.Remove(consulta);
        }

        public static List<Consulta> ListaConsultas()
        {
            return consultas;
        }

        /// <summary>
        /// Método que obtem a lista de cirurgias que o paciente fez numa certa data
        /// </summary>
        public static List<Consulta> ListaPaciente(int nus, DateTime dataInicio, DateTime dataFim)
        {
            List<Consulta> i = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == nus && consulta.data >= dataInicio && consulta.data <= dataFim)
                {
                    i.Add(consulta);
                }
            }
            return i;
        }
        #endregion
        #endregion
    }
}
