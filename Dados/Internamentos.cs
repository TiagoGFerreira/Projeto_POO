/*
 * Classe Internamentos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
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

        /// <summary>
        /// Método retornar a lista de internamentos
        /// </summary>
        public static List<Internamento> ListaInternamento()
        {
            return internamentos;
        }


        /// <summary>
        /// Método que obtem a lista de internamentos que o paciente fez numa certa data
        /// </summary>
        public static int CalcularDiasInternamento(int nus, DateTime dataInicio, DateTime dataFim)
        {
            int totalDiasInternamento = 0;

            foreach (Internamento internamento in Internamentos.ListaInternamento())
            {
                // Verifica se o internamento está dentro do intervalo desejado e para o paciente especificado
                if (internamento.nus == nus && internamento.datai >= dataInicio && internamento.dataf <= dataFim)
                {
                    // Calcula a diferença em dias entre as datas de início e fim do internamento
                    int diasInternamento = (internamento.dataf - internamento.datai).Days;

                    // Acumula o número de dias ao total
                    totalDiasInternamento += diasInternamento;
                }
            }

            return totalDiasInternamento;
        }
        #endregion
        #endregion
    }
}
