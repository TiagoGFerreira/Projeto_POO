/*
 * Classe Pacientes
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using Objetos;
using System.Collections.Generic;
using System.Linq;

namespace Dados
{
    public static class Pacientes
    {
        /// <summary>
        /// Classe Pacientes
        /// </summary>
        #region ATRIBUTOS

        private static List<Paciente> pacientes = new List<Paciente>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Paciente , Pacientes
        /// </summary>
        public static List<Paciente> ListadePacientes
        {
            get
            {
                return pacientes;
            }
            set
            {
                pacientes = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adcionar um paciente da lista de pacientes
        /// </summary>

        public static void AdicionarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        /// <summary>
        /// Método para remover um paciente da lista de pacientes
        /// </summary>

        public static void RemoverPaciente(Paciente paciente)
        {
            pacientes.Remove(paciente);
        }

        /// <summary>
        /// Método que obtem paciente através NUS
        /// </summary>
        public static Paciente ObterPacientePorNUS(int nus)
        {
            return ListadePacientes.FirstOrDefault(p => p.nus == nus);
        }

        /// <summary>
        /// Retorna o objeto paciente de acordo com o seu Nr de utentne
        /// </summary>
        public static List<Paciente> ListaPacientes()
        {
            return pacientes;
        }

        #endregion
        #endregion
    }
}