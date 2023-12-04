/*
 * Classe Consulta
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using System;

namespace Objetos
{
    /// <summary>
    /// Classe Consulta
    /// </summary>
    public class Consulta
    {
        #region ATRIBUTOS 
        private DateTime Data;
        private string Descricao;
        private int NUS;
        private int idMedico;


        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Consulta
        /// </summary>
        public Consulta(int idM, int nus, DateTime data, string descricao)
        {
            idMedico = idM;
            NUS = nus;
            Data = data;
            Descricao = descricao;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a data da consulta
        /// </summary>
        public DateTime data
        {
            get { return Data; }
            set { Data = value; }
        }

        /// <summary>
        /// Propriedade que retorna a descricao da consulta
        /// </summary>
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
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
        /// Override do método ToString para formatar as informações da Consulta
        /// </summary>
        public override string ToString()
        {
            return $"Data: {Data}\nDescrição: {Descricao}\nNUS Paciente: {nus}\nID Medico Responsavel: {idMedico}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos
        /// <summary>
        /// Método que retorna a descrição de uma consulta especifica
        /// </summary>
        public string GetDescricao()
        {
            return Descricao;
        }

        /// <summary>
        /// Método que retorna a data de uma consulta especifica
        /// </summary>
        public DateTime GetData()
        {
            return Data;
        }
        #endregion
        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Consulta()
        {

        }
        #endregion
        #endregion
    }
}
