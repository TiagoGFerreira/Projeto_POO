/*
 * Classe Cirurgias
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using Excecoes;
using Objetos;

namespace Dados
{
    public static class Cirurgias
    {
        /// <summary>
        /// Classe Cirurgias
        /// </summary>
        #region ATRIBUTOS

        private static List<Cirurgia> cirurgias = new List<Cirurgia>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Cirurgia , Cirurgias
        /// </summary>
        public static List<Cirurgia> ListadeCirurgias
        {
            get
            {
                return cirurgias;
            }
            set
            {
                cirurgias = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma cirurgia na lista de cirurgias
        /// </summary>

        public static void AdicionarCirurgia(Cirurgia cirurgia)
        {
            cirurgias.Add(cirurgia);
        }

        /// <summary>
        /// Método para remover uma cirurgia na lista de cirurgias
        /// </summary>

        public static void RemoverCirurga(Cirurgia cirurgia)
        {
            cirurgias.Remove(cirurgia);
        }

        public static List<Cirurgia> ListaCirurgias()
        {
            return cirurgias;
        }

        /// <summary>
        /// Método que obtem a lista de consultas que o paciente fez numa certa data
        /// </summary>
        public static List<Cirurgia> ListaPaciente(int nus, DateTime dataInicio, DateTime dataFim)
        {
            List<Cirurgia> i = new List<Cirurgia>();
            foreach (Cirurgia cirurgia in cirurgias)
            {
                if (dataFim <= dataInicio)
                {
                    throw new DataInvalidaException("Data invalida");
                }
                if (cirurgia.nus == nus)
                {
                    i.Add(cirurgia);
                }
            }
            return i;
        }
        #endregion
        #endregion
    }
}
