/*
 * Classe Exame
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */


using Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Objetos
{
    /// <summary>
    /// Classe Exame
    /// </summary>
    public class Exame
    {
        #region ATRIBUTOS
        private DateTime Data;
        private string Nome;
        private string Resultado;
        private int NUS;
        private int idMedico;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES
        /// <summary>
        /// Construtor com parâmetros da Classe Exame
        /// </summary>
        public Exame(string nome , string resultado ,int nus, int MedicoID, DateTime data)
        {
            try
            {
                if (data < DateTime.Now)
                {
                    throw new DataInvalidaException("Data de nascimento incorreta");
                }
                Data = data;
                Nome = nome;
                Resultado = resultado;
                NUS = nus;
                idMedico = MedicoID;
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
        /// Propriedade que retorna nome do exame
        /// </summary>
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        /// <summary>
        /// Propriedade que retorna resultado do exame
        /// </summary>
        public string resultado
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        /// <summary>
        /// Propriedade que retorna a data em que o exame foi realizado
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
        /// Override do método ToString para formatar as informações do Exame
        /// </summary>
        public override string ToString()
        {
            return $"Data: {Data}\nNUS Paciente: {nus}\nID Medico Responsavel: {idMedico}\nResultado: {Resultado}\n------------------------------";
        }
        #endregion

        #region Outros Métodos
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Exame()
        {

        }
        #endregion
        #endregion

    }
}
