/*
 * Classe Custo
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 12-11-2023
 * POO-LESI
 */


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
