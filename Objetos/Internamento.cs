/*
 * Classe Internamento
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */

using Excecoes;
using System;
using System.Collections.Generic;

namespace Objetos
{
    /// <summary>
    /// Classe Internamento
    /// </summary>
    public class Internamento
    {
        #region ATRIBUTOS 
        private string Motivo;
        private DateTime DataInicio;
        private DateTime DataFim;
        private int NUS;
        private int idMedico;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Internamento
        /// </summary>

        public Internamento(string motivo, int idM, int nus, DateTime data)
        {
            try
            {
                if (data < DateTime.Now)
                {
                    throw new DataInvalidaException("Data invalida");
                }
                Motivo = motivo;
                NUS = nus;
                idMedico = idM;
                DataInicio = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                throw;
            }
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Propriedade que retorna a string motivo
        /// </summary>
        public string motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        /// <summary>
        /// Propriedade que retorna a data de inicio do internamento
        /// </summary>
        public DateTime datai
        {
            get { return DataInicio; }
            set { DataInicio = value; }
        }

        /// <summary>
        /// Propriedade que retorna a data final do internamento
        /// </summary>
        public DateTime dataf
        {
            get { return DataFim; }
            set { DataFim = value; }
        }

        /// <summary>
        /// Propriedade que retorna o id do medico
        /// </summary>
        public int MedicoID
        {
            get { return idMedico; }
            set { idMedico = value; }
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

        #region Overrides
        /// <summary>
        /// Override do método ToString para formatar as informações do Internamento
        /// </summary>
        public override string ToString()
        {
            return $"Data: {DataInicio}\nMotivo: {Motivo}\nNUS Paciente: {nus}\nID Medico Responsavel: {idMedico}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método que adiciona a data final ao internamento
        /// </summary>
        public static void FimInternamento(Internamento internamento,DateTime datafim)
        {
            internamento.DataFim = datafim;
        }
        

        #endregion
        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Internamento()
        {

        }
        #endregion
        #endregion
    }
}
