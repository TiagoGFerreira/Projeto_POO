/*
 * Classe Pessoa
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */

using System;
using Excecoes;

namespace Objetos
{
    /// <summary>
    /// Classe Pessoa
    /// </summary>

    [Serializable]
    public class Pessoa : PessoaBase
    {
        #region ATRIBUTOS

        private string nome;
        private DateTime nascimento;
        private string sexo;
        private int idPessoa;
        private static int nPessoa = 1;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor com parâmetros da Classe Pessoa
        /// </summary>

        public Pessoa()
        {
            idPessoa = nPessoa;
            nPessoa++;
            nome = string.Empty;
            nascimento = DateTime.MinValue;
            sexo = string.Empty;
        }
        public Pessoa(string Nome, DateTime Nascimento, string Sexo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Sexo))
                {
                    throw new ArgumentoNuloException("Nome ou Sexo nao podem ir vazios");
                }

                if (Nascimento > DateTime.Now)
                {
                    throw new DataInvalidaException("Data de nascimento incorreta");
                }

                string nSexo = Sexo.ToUpper();
                if (!(nSexo.Equals("MASCULINO") || nSexo.Equals("FEMININO")))
                {
                    throw new SexoInvalidoException("Sexo deve ser Masculino ou Feminino");
                }

                idPessoa = nPessoa;
                nPessoa++;
                nome = Nome;
                nascimento = Nascimento;
                sexo = nSexo;
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
        /// Propriedade que retorna o Nome da Pessoa
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade que retorna o Sexo da Pessoa
        /// </summary>
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value;}
        }

        /// <summary>
        /// Propriedade que retorna a data de nascimento da Pessoa
        /// </summary>
        public DateTime DataNasc
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        /// <summary>
        /// Propriedade que retorna o valor da idade obtido no Método GetIdade
        /// </summary>
        public int Idade
        {
            get { return GetIdade(nascimento); }
        }

        /// <summary>
        /// Propriedade que retorna o id da pessoa
        /// </summary>
        public int PessoaID
        {
            get { return idPessoa; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override do método ToString para formatar as informações da pessoa
        /// </summary>
        public override string ToString()
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nData de Nascimento: {DataNasc.ToShortDateString()}\nSexo: {Sexo}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {

        }
        #endregion
        #endregion
    }
}

