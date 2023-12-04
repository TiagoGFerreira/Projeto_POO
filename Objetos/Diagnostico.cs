/*
 * Classe Diagnóstico
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 10-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;


namespace Objetos
{
    /// <summary>
    /// Classe Diagnóstico
    /// </summary>
    public class Diagnostico
    {
        #region ATRIBUTOS
        private DateTime Data;
        private string descricao;
        private List<Exame> examesfeitos;
        private int NUS;
        private int idMedico;
        private static List<Diagnostico> diagnosticos;
        #endregion

        #region COMPORTAMENTO
        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parâmetros da Classe Diagnóstico
        /// </summary>
        public Diagnostico(string Descricao , int idM, int nus)
        {
            Data = DateTime.Now;
            descricao = Descricao;
           // examesfeitos = Exame.ObterExamesPorPaciente(Paciente.ObterPacientePorNUS(nus));
            idMedico = idM;
            NUS = nus;
            diagnosticos.Add(this);
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
        /// Override do método ToString para formatar as informações do Diagnóstico
        /// </summary>
        public override string ToString()
        {
            return $"Data: {Data}\nMotivo: {Descricao}\nNUS Paciente: {nus}\nID Medico Responsavel: {idMedico}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos
        /// <summary>
        /// Método que remove o diagnóstico da lista diagnósticos
        /// </summary>
        public void RemoverDiagnostico(Diagnostico diagnóstico)
        {
            diagnosticos.Remove(diagnóstico);
        }
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
