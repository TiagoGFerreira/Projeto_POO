/*
 * Classe Medico
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 07-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Objetos
{
    /// <summary>
    /// Classe Médico, herda da classe Pessoa
    /// </summary>
    public class Medico : Pessoa
    {
        #region ATRIBUTOS 
        private string Especialidade;
        private int idMedico;
        private static int nMedico = 1;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        
        /// <summary>
        /// Construtor com parâmetros da Classe Médico
        /// </summary>
        public Medico(Pessoa pessoa,string especialidade) : base(pessoa.Nome, pessoa.DataNasc, pessoa.Sexo)
        {
            idMedico = nMedico;
            nMedico++;
            Especialidade = especialidade;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna o id do medico
        /// </summary>
        public int MedicoID
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        /// <summary>
        /// Propriedade que retorna da classe Especialidade o nome da mesma
        /// </summary>
        public string Especialidades
        {
            get { return Especialidade; }
            set { Especialidade = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override do método ToString para formatar as informações da Médico chamando também o toString da classe base Pessoa
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()}\nEspecialidades: {Especialidades}\n------------------------------";
        }
        #endregion

        #region OutrosMétodos

        

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Medico()
        {

        }
        #endregion
        #endregion
    }

}
