/*
 * Classe Cirurgia
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using Excecoes;
using System;

namespace Objetos
{
    /// <summary>
    /// Classe Cirurgia
    /// </summary>
    public class Cirurgia
    {
        #region ATRIBUTOS 
        private string Nome;
        private DateTime Data;
        private int NUS;
        private int IdMedico;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Cirurgia
        /// </summary>
        public Cirurgia(string nome, int idmedico, int nus, DateTime data)
        {
            try
            {
                if (data < DateTime.Now)
                {
                    throw new DataInvalidaException("Data invalida");
                }
                NUS = nus;
                IdMedico = idmedico;
                Data = data;
                Nome = nome;
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
        /// Propriedade que retorna o nome da cirurgia
        /// </summary>
        public string nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade que retorna a data de cirurgia
        /// </summary>
        public DateTime data
        {
            get { return Data; }
            set { Data = value; }
        }

        /// <summary>
        /// Propriedade que retorna o id do medico
        /// </summary>
        public int MedicoID
        {
            get { return IdMedico; }
            set { IdMedico = value; }
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
        /// Override do método ToString para formatar as informações da Cirurgia
        /// </summary>
        public override string ToString()
        {

            return $"Data: {Data}\nNome da Cirurgia: {Nome}\nNUS Paciente: {nus}\nID Medico Responsavel: {IdMedico}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Cirurgia()
        {

        }
        #endregion
        #endregion
    }
}
