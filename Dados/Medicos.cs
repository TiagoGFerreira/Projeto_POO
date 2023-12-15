/*
 * Classe Medicos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Excecoes;
using Objetos;


namespace Dados
{
    public static class Medicos
    {
        /// <summary>
        /// Classe Medicos
        /// </summary>
        #region ATRIBUTOS

        private static List<Medico> medicos = new List<Medico>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Medico , Medicos
        /// </summary>
        public static List<Medico> ListadeMedicos
        {
            get
            {
                return medicos;
            }
            set
            {
                medicos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adcionar um medico da lista de medicos
        /// </summary>

        public static void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        /// <summary>
        /// Método para remover um medico da lista de medicos
        /// </summary>

        public static void RemoverMedico(Medico medico)
        {
            medicos.Remove(medico);
        }

        /// <summary>
        /// Método para obter o medico atraves do seu id
        /// </summary>
        public static Medico ObterMedicoPorId(int id)
        {
            return medicos.FirstOrDefault(medico => medico.MedicoID == id);
        }


        public static bool VerificaIDMedico(int idM)
        {
            bool verificaIDMedico = false;

            foreach (Medico medico in medicos)
            {
                if (medico.MedicoID == idM)
                {
                    verificaIDMedico = true;
                    return verificaIDMedico;
                }
            }

            if (!verificaIDMedico)
            {
                throw new IDException("ID nao existe");
            }

            return verificaIDMedico; 
        }


        public static List<Medico> ListaMedicos()
        {
            return medicos;
        }
        #endregion
        #endregion
    }
}
