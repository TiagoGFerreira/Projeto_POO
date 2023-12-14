/*
 * Classe Diagnóstico
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 10-11-2023
 * POO-LESI
 */

using Excecoes;
using System;


namespace Objetos
{
    /// <summary>
    /// Classe Diagnóstico
    /// </summary>
    public class Diagnostico
    {
        #region ATRIBUTOS
        private DateTime data;
        private string descricao;
        private int NUS;
        private int idMedico;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Diagnóstico
        /// </summary>
        public Diagnostico(string Descricao, int idM, int nus, DateTime Data)
        {
            try
            {
                if (data < DateTime.Now)
                {
                    throw new DataInvalidaException("Data de nascimento incorreta");
                }
                descricao = Descricao;
                NUS = nus;
                idMedico = idM;
                data = Data;
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
        /// Propriedade que retorna a descrição do diagnóstico
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade que retorna a data do diagnóstico
        /// </summary>
        public DateTime DataD
        {
            get { return data; }
            set { data = value; }
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
        /// Override do método ToString para formatar as informações do Diagnóstico
        /// </summary>
        public override string ToString()
        {
            return $"Data: {DataD}\nMotivo: {Descricao}\nNUS Paciente: {nus}\nID Medico Responsavel: {idMedico}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Diagnostico()
        {

        }
        #endregion
        #endregion
    }
}
