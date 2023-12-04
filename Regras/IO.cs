/*
 * Classe Custo
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 14-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using Objetos;

namespace Regras
{
    /// <summary>
    /// Classe Input/Output
    /// </summary>
    public class IO
    {
        /// <summary>
        /// Método que imprime as consultas que o medico especifico irá ter
        /// </summary>
        public void MostrarConsultasMedico(List<Consulta> consultas, int idMedico)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.MedicoID == idMedico)
                {
                    Console.WriteLine($"Data: {consulta.GetData()}");
                    Console.WriteLine($"Descrição: {consulta.GetDescricao()}");
                    Console.WriteLine($"idMédico: {idMedico}");
                    Console.WriteLine("------------------------------");
                }
            }
        }

        /// <summary>
        /// Método que imprime as consultas que o paciente especifico irá ter
        /// </summary>
        public void MostrarConsultasPaciente(List<Consulta> consultas, int nus)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == nus)
                {
                    Console.WriteLine($"Data: {consulta.GetData()}");
                    Console.WriteLine($"Descrição: {consulta.GetDescricao()}");
                    Console.WriteLine($"Nus: {nus}");
                    Console.WriteLine("------------------------------");
                }
            }
        }

        /// <summary>
        /// Método que imprime as doencas que o paciente contém
        /// </summary>
        public void DoencasPaciente(int NUS, List<Paciente> doencas)
        {
            foreach (Paciente doenca in doencas)
            {
                if (doenca.nus == NUS)
                {
                    Console.WriteLine("Doença: " + doenca);
                }
            }
        }

        /// <summary>
        /// Método que mostra as consultas que o paciente tem agendadas
        /// </summary>
        public void ConsultasAgendadas(int NUS, List<Consulta> consultas)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == NUS)
                {
                    Console.WriteLine("Data da consulta: " + consulta.data.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }


    }
}
