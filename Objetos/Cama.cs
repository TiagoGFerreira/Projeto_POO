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
            set { Estado = value; }
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
