﻿/*
 * Classe Internamento
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */

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
        private int idCama;
        private static List<Internamento> internamentos = new List<Internamento>();
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Internamento
        /// </summary>

        public Internamento(string motivo, int idM, int nus, int idCama)
        {
            Motivo = motivo;
            NUS = nus;
            idMedico = idM;
            DataInicio = DateTime.Now;
            internamentos.Add(this);
            this.idCama = idCama;
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
        /// Propriedade que retorna o id da cama
        /// </summary>
        public int CamaID
        {
            get { return idCama; }
            set { idCama = value; }
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
        public void FimInternamento(Internamento internamento,DateTime datafim)
        {
            internamento.DataFim = datafim;
        }

        /// <summary>
        /// Método que remove o internamento da lista internamentos
        /// </summary>
        public void RemoveInternamento(Internamento internamento)
        {
            internamentos.Remove(internamento);
        }

        /// <summary>
        /// Método que obtem o calculo pelos internamentos que o paciente fez no hospital
        /// Ainda em desenvolvimento
        /// </summary>
        public float CalcularCustoTotal(Custo custo, int nus, DateTime dataInicial, DateTime dataFinal)
        {
            if (NUS == nus)
            {
                float custoInternamento = (dataFinal - dataInicial).Days * custo.Custointernamento;
                return custoInternamento;
            }

            return 0;
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
