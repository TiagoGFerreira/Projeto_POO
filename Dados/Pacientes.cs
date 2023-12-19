/*
 * Classe Pacientes
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using Objetos;
using Excecoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    [Serializable]
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
        /// Método que verifica se o NR Utente está no formato correto e se realmente está guardado na lista
        /// </summary>
        public static bool VerificaNUS(int nus)
        {
            if (!(nus.ToString().Length == 9))
            {
                throw new NUSException("O NR Utente de saude nao e valido");
            }

            bool verificaNUS = false;

            foreach (Paciente paciente in pacientes)
            {
                if (paciente.nus == nus)
                {
                    verificaNUS = true;
                    return verificaNUS;
                }
            }

            if (!verificaNUS)
            {
                throw new NUSException("O NR Utente de saude nao existe");
            }

            return verificaNUS; 
        }

        /// <summary>
        /// Retorna o objeto paciente de acordo com o seu Nr de utentne
        /// </summary>
        public static List<Paciente> ListaPacientes()
        {
            return pacientes;
        }

        /// <summary>
        /// Método que serializa e guarda a lista de pacientes num ficheiro binário
        /// </summary>
        public static bool GuardarPacientes(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    using (File.Create(fileName)) { }
                }
                using (Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, pacientes);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        /// <summary>
        /// Método que carrega os pacientes de um ficheiro binário e adiciona-os à lista atual.
        /// </summary>
        public static bool CarregarPacientes(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    List<Paciente> pacientesCarregados = (List<Paciente>)b.Deserialize(s);

                    pacientes.Clear();
                    pacientes.AddRange(pacientesCarregados);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        /// <summary>
        /// Método que verifica e compara se já não existe um paciente igual na lista , senao existir retorna true
        /// </summary>
        public static bool PacienteExiste(Paciente p)
        {
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.nus == p.nus)
                {
                    return false;
                }
            }
            return true; 
        }
        #endregion
        #endregion
    }
}