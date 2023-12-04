/*
 * Classe Paciente
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using System.Linq;

namespace Objetos
{
    /// <summary>
    /// Classe Paciente, herda da classe Pessoa
    /// </summary>
    public class Paciente : Pessoa
    {
        #region ATRIBUTOS 
        private int NUS;
        private List<string> Doencas;
        private List<Consulta> Consultas;
        private List<Diagnostico> Diagnosticos;
        private List<Exame> Exames;
        private List<Cirurgia> Cirurgias;

        #endregion

        #region COMPORTAMENTO


        #region CONSTRUTORES
        /// <summary>
        /// Construtor com parâmetros da Classe Paciente
        /// </summary>
        public Paciente(int nus, Pessoa pessoa) : base(pessoa.Nome, pessoa.DataNasc, pessoa.Sexo)
        {
            NUS = nus;
            Doencas = new List<string>();
            Consultas = new List<Consulta>();
            Cirurgias = new List<Cirurgia>();
            Exames = new List<Exame>();
            Diagnosticos = new List<Diagnostico>();
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna Nr Utente de Saude do Paciente
        /// </summary>
        public int nus
        {
            get { return NUS; }
            set { NUS = value; }
        }

        /// <summary>
        /// Propriedade que retorna a lista de doencas que o paciente tem
        /// </summary>
        public List<string> doencas
        {
            get { return Doencas; }
            set { Doencas = value; }
        }

        /// <summary>
        /// Propriedade que retorna a lista de consultas que o paciente tem agendadas
        /// </summary>
        public List<Consulta> consulta
        {
            get { return Consultas; }
            set { Consultas = value; }
        }

        /// <summary>
        /// Propriedade que retorna a lista de exames do paciente
        /// </summary>
        public List<Exame> exame
        {
            get { return Exames; }
            set { Exames = value; }
        }

        /// <summary>
        /// Propriedade que retorna a lista de exames do paciente
        /// </summary>
        public List<Cirurgia> cirurgia
        {
            get { return Cirurgias; }
            set { Cirurgias = value; }
        }

        /// <summary>
        /// Propriedade que retorna a lista de exames do paciente
        /// </summary>
        public List<Diagnostico> diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }


        #endregion

        #region Overrides
        /// <summary>
        /// Override do método ToString para formatar as informações da Paciente chamando também o toString da classe base Pessoa
        /// </summary>
        public override string ToString()
        {
            // Adiciona informações específicas da classe Paciente e chama ToString da classe base (Pessoa)
            return $"{base.ToString()}\nNúmero Utente de Saúde: {nus}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma consulta á lista de consultas do paciente
        /// </summary>
        public void AdicionarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }

        /// <summary>
        /// Método para adicionar um diagnostico á lista de diagnósticos do paciente
        /// </summary>
        public void AdicionarDiagnostico(Diagnostico diagnostico)
        {
            Diagnosticos.Add(diagnostico);
        }

        /// <summary>
        /// Método para adicionar um exames á lista de exames do paciente
        /// </summary>
        public void AdicionarExame(Exame exame)
        {
            Exames.Add(exame);
        }

        /// <summary>
        /// Método para adicionar uma cirurgia á lista de cirurgias do paciente
        /// </summary>
        public void AdicionarCirurgia(Cirurgia cirurgia)
        {
            Cirurgias.Add(cirurgia);
        }

        /// <summary>
        /// Método para adicionar uma doença á lista de doenças do paciente
        /// </summary>
        public void AdicionarDoenca(string doenca)
        {
            Doencas.Add(doenca);
        }

        /// <summary>
        /// Método que obtem o calculo pelos serviços que o paciente fez no hospital
        /// Ainda em desenvolvimento
        /// </summary>
        /*
        public float CalcularCustoTotal(Custo custo)
        {
            if(consulta != null) { 
            }
            float custoConsultas = Consultas.Count * custo.Custoconsulta;
            float custoExames = exames.Count * custo.Custoexame;
            float custoCirurgias = cirurgias.Count * custo.Custocirugia;

            return custoConsultas + custoExames + custoCirurgias;
        }
        */
        #endregion
        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Paciente()
        {

        }
        #endregion
        #endregion
    }
}
