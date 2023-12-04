/*
 * Classe Custo
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Objetos
{
    /// <summary>
    /// Classe Custo
    /// </summary>
    public class Custo
    {
        #region ATRIBUTOS 
        private float custofinal;
        private int NUS;
        private float CustoConsulta;
        private float CustoExame;
        private float CustoCirurgia;
        private float CustoDiagnostico;
        private List<Consulta> Consultas = new List<Consulta>();
        private List<Diagnostico> Diagnosticos = new List<Diagnostico>();
        private List<Exame> Exames = new List<Exame>();
        private List<Cirurgia> Cirurgias = new List<Cirurgia>();

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor com parâmetros da Classe Custo
        /// </summary>
        public Custo()
        {

        }

        public Custo(int nus)
        {
            NUS = nus;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Propriedade que retorna o custo final
        /// </summary>
        public float custo
        {
            get { return custofinal; }
            set { custofinal = value; }
        }
        /// <summary>
        /// Propriedade que retorna Nr Utente de Saude do Paciente
        /// </summary>
        public int nus
        {
            get { return NUS; }
            set { NUS = value; }
        }

        /// <summary>
        /// Propriedade que retorna o custo da consulta
        /// </summary>
        public float Custoconsulta
        {
            get { return 19; }
            set { CustoConsulta = value; }
        }
        /// <summary>
        /// Propriedade que retorna o custo da cirurgia
        /// </summary>
        public float Custocirugia
        {
            get { return 20; }
        }

        /// <summary>
        /// Propriedade que retorna o custo do exame
        /// </summary>
        public float Custoexame
        {
            get { return 20; }
        }

        /// <summary>
        /// Propriedade que retorna o custo do internamento
        /// </summary>
        public float Custodiagnostico
        {
            get { return 20; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override do método ToString para formatar as informações do Custo
        /// </summary>
        public override string ToString()
        {
            return $"NUS Paciente: {nus}\nCusto Final: {custofinal}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método que obtem o calculo pelos serviços que o paciente fez no hospital
        /// Ainda em desenvolvimento
        /// </summary>

        /// <summary>
        /// Método que obtem a lista de todas as consultas dentro das datas indicadas
        /// </summary>
        public static List<Consulta> NRConsultas(List<Consulta> lista ,DateTime dataInicio, DateTime dataFim)
        {
            return lista.Where(c => c.data >= dataInicio && c.data <= dataFim).ToList();
        }

        /// <summary>
        /// Método que obtem a lista de todas as cirurgias dentro das datas indicadas
        /// </summary>
        public static List<Cirurgia> NRCirurgias(List<Cirurgia> lista, DateTime dataInicio, DateTime dataFim)
        {
            return lista.Where(c => c.data >= dataInicio && c.data <= dataFim).ToList();
        }

        /// <summary>
        /// Método que obtem a lista de todas os diagnosticos dentro das datas indicadas
        /// </summary>
        public static List<Diagnostico> NRDiagnosticos(List<Diagnostico> lista, DateTime dataInicio, DateTime dataFim)
        {
            return lista.Where(c => c.DataD >= dataInicio && c.DataD <= dataFim).ToList();
        }

        /// <summary>
        /// Método que obtem a lista de todas os exames dentro das datas indicadas
        /// </summary>
        public static List<Exame> NRExames(List<Exame> lista, DateTime dataInicio, DateTime dataFim)
        {
            return lista.Where(c => c.DataD >= dataInicio && c.DataD <= dataFim).ToList();
        }


        public float CustoTotal(int nus, DateTime dataI, DateTime dataF)
        {
            Paciente paciente = Dados.Pacientes.ObterPacientePorNUS(nus);
            if (paciente != null)
            {
                float custoConsultas = NRConsultas(paciente.consulta, dataI, dataF).Count * CustoConsulta;
                float custoExames = NRExames(paciente.exame, dataI, dataF).Count * CustoExame;
                float custoCirurgias = NRCirurgias(paciente.cirurgia, dataI, dataF).Count * CustoCirurgia;
                float custoDiagnostico = NRDiagnosticos(paciente.diagnostico, dataI, dataF).Count * CustoDiagnostico;
                return custoConsultas + custoExames + custoCirurgias + custoDiagnostico;
            }

            return 0;
        }


        #endregion
        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Custo()
        {

        }
        #endregion
        #endregion
    }
}
