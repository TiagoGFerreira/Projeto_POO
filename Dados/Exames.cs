/*
 * Classe Exames
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using Excecoes;
using Objetos;

namespace Dados
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
        public static List<Exame> ListaExames()
        {
            return exames;
        }

        /// <summary>
        /// Método que obtem a lista de exames que o paciente fez numa certa data
        /// </summary>
        public static List<Exame> ListaPaciente(int nus, DateTime dataInicio, DateTime dataFim)
        {
            List<Exame> i = new List<Exame>();
            foreach (Exame exame in exames)
            {
                if (dataFim <= dataInicio)
                {
                    throw new DataInvalidaException("Data invalida");
                }
                if (exame.nus == nus)
                {
                    i.Add(exame);
                }
            }
            return i;
        }
        
        #endregion
        #endregion
    }
}
