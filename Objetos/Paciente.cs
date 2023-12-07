/*
 * Classe Paciente
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */

using System.Collections.Generic;

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
