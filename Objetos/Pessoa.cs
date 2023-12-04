/*
 * Classe Pessoa
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */


using System;
using System.Collections.Generic;

namespace Objetos
{
    /// <summary>
    /// Classe Pessoa
    /// </summary>
    public class Pessoa
    {
        #region ATRIBUTOS 

        private string nome;
        private int idade;
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
            idade = 0;
        }
        public Pessoa(string Nome, DateTime Nascimento, string Sexo)
        {
            idPessoa = nPessoa;
            nPessoa++;
            nome = Nome;
            nascimento = Nascimento;
            sexo = Sexo;
            idade = Idade;
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
            set { sexo = value; }
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
            get { return GetIdade; }
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

        /// <summary>
        /// O método GetIdade substrai a data atual á data de nacimento da pessoa para obter a sua idade
        /// </summary>
        public int GetIdade
        {
            get
            {
                DateTime dataAtual = DateTime.Now;

                int idade = dataAtual.Year - nascimento.Year;

                if (nascimento.Date > dataAtual.AddYears(-idade))
                {
                    //No caso da pessoa ainda não ter feito anos
                    idade--;
                }

                return idade;
            }
        }


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

