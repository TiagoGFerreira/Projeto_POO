/*
 * Classe Paciente
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using System;

namespace Objetos
{
    /// <summary>
    /// Classe Cama
    /// </summary>
    public class Cama
    {
        #region ATRIBUTOS 
        private int NumeroCama;
        private bool Estado;
        private static int pNumeroCama = 1;
        private int NUS;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão da classe Cama
        /// </summary>
        public Cama()
        {
            NumeroCama = pNumeroCama;
            pNumeroCama++;
            Estado = false;
            NUS = 0;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna o numero da cama 
        /// </summary>
        public int Numerocama
        {
            get { return NumeroCama; }
        }

        /// <summary>
        /// Propriedade que retorna o estado da cama 
        /// </summary>
        public bool EstadoCama
        {
            get { return Estado; }
        }

        /// <summary>
        /// Propriedade que retorna Nr Utente de Saude do Paciente
        /// </summary>
        public int nus
        {
            get { return NUS; }
            set { NUS = value; }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método que adiciona um paciente á cama
        /// </summary>

        public void AdicionarPaciente(int nus)
        {
            if (!Estado)
            {
                NUS = nus;
                Estado = true; // A cama está ocupada
                Console.WriteLine($"O Paciente com o nr utente {nus} associado à cama {NumeroCama}.");
            }
            else
            {
                Console.WriteLine($"A cama {NumeroCama} já está ocupada.");
            }
        }

        /// <summary>
        /// Método que remove um paciente da cama
        /// </summary>
        public void RemoverPaciente()
        {
            if (Estado)
            {
                Console.WriteLine($"Paciente com o nr {nus} removido da cama {NumeroCama}.");
                nus = 0;
                Estado = false; // A cama está desocupada
            }
            else
            {
                Console.WriteLine($"A cama {NumeroCama} já está desocupada.");
            }
        }

        /// <summary>
        /// Método para obter o estado da cama
        /// </summary>
        public bool ObterEstado()
        {
            return Estado;
        }
        #endregion
        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Cama()
        {

        }
        #endregion
        #endregion
    }
}
