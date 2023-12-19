/*
 * Classe Custos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */
using System;
using System.Collections.Generic;
using Objetos;
using Excecoes;

namespace Dados
{
    public static class Custos
    {
        /// <summary>
        /// Classe Custos
        /// </summary>
        #region ATRIBUTOS
        private static double CustoConsulta = 30;
        private static double CustoExame = 15.99;
        private static double CustoCirurgia = 79.95;
        private static double CustoDiagnostico = 45.5;
        private static double CustoInternamento = 50;
        private static List<Custo> custos = new List<Custo>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que retorna a lista da classe Custo , Custos
        /// </summary>
        public static List<Custo> ListadeCustos
        {
            get
            {
                return custos;
            }
            set
            {
                custos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar um custo na lista de custos
        /// </summary>
        public static void AdicionarCusto(Custo custo)
        {
            custos.Add(custo);
        }



        /// <summary>
        /// Método para remover um custo na lista de custos
        /// </summary>
        public static void RemoverCusto(Custo custo)
        {
            custos.Remove(custo);
        }

        /// <summary>
        /// Método que retorna o custo final do serviços prestados ao cliente
        /// </summary>
        public static double CustoTotal(int nus, DateTime dataI, DateTime dataF)
        {
            Paciente paciente = Pacientes.ObterPacientePorNUS(nus);
            if (paciente != null)
            {
                double custoConsultas = Consultas.ListaPaciente(nus, dataI, dataF).Count * CustoConsulta;
                double custoExames = Exames.ListaPaciente(nus, dataI, dataF).Count * CustoExame;
                double custoCirurgias = Cirurgias.ListaPaciente(nus, dataI, dataF).Count * CustoCirurgia;
                double custoDiagnosticos = Diagnosticos.ListaPaciente(nus, dataI, dataF).Count * CustoDiagnostico;
                double custoInternamentos = Internamentos.CalcularDiasInternamento(nus,dataI,dataF) * CustoInternamento;
                return custoConsultas + custoExames + custoCirurgias + custoDiagnosticos + custoInternamentos;
            }
            else
            {
                throw new CustoException("Nao foi possivel calcular o custo");
            }
        }

        /// <summary>
        /// Método que retorna a lista custos
        /// </summary>
        public static List<Custo> ListaCustos()
        {
            return custos;
        }
        #endregion
        #endregion
    }
}
