/*
 * Classe Cirurgia
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;

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
        private List<int> IdsMedicos;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Cirurgia
        /// </summary>
        public Cirurgia(string nome , List<int> idsMedicos, int nus, DateTime data) 
        {
            Nome = nome;
            NUS = nus;
            IdsMedicos = idsMedicos;
            Data = data;
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
        public List<int> MedicoID
        {
            get { return IdsMedicos; }
            set { IdsMedicos = value; }
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
            string idsMedicosStr = string.Join(", ", IdsMedicos);

            return $"Data: {Data}\nNome da Cirurgia: {Nome}\nNUS Paciente: {nus}\nID Medico Responsavel: {idsMedicosStr}\n------------------------------";
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
