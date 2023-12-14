/*
 * Classe Custo
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 14-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Objetos;


namespace GerirHospital
{
    /// <summary>
    /// Classe Input/Output
    /// </summary>
    public class IO
    {
        /// <summary>
        /// Método que imprime as consultas que o medico especifico irá ter
        /// </summary>
        public static void MostrarConsultasMedico(List<Consulta> consultas, int idMedico)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.MedicoID == idMedico )
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
        public void ConsultasAgendadasPaciente(int NUS, List<Consulta> consultas)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == NUS && DateTime.Now <= consulta.data)
                {
                    Console.WriteLine("Data da consulta: " + consulta.GetData());//consulta.data.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        /// <summary>
        /// Método que mostra as consultas que o medico tem agendadas
        /// </summary>
        public void ConsultasAgendadasMedico(int idMedico, List<Consulta> consultas)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.MedicoID == idMedico && DateTime.Now <= consulta.data)
                {
                    Console.WriteLine("Data da consulta: " + consulta.GetData());//consulta.data.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        /// <summary>
        /// Método que todas as cirurgias
        /// </summary>
        public void HistoricoCirurgias(List<Cirurgia> cirurgias)
        {
            foreach(Cirurgia cirurgia in cirurgias)
            {
                Console.WriteLine($"Nome: {cirurgia.nome}");
                Console.WriteLine($"Data: {cirurgia.data.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {cirurgia.nus}");
                Console.WriteLine($"idMédico: {cirurgia.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os internamentos
        /// </summary>
        public void HistoricoInternamentos(List<Internamento> internamentos)
        {
            foreach (Internamento internamento in internamentos)
            {
                Console.WriteLine($"Nome: {internamento.motivo}");
                Console.WriteLine($"Data de Inicio: {internamento.datai.ToShortDateString()}");
                if(internamento.dataf > internamento.datai)
                {
                    TimeSpan diferenca = internamento.dataf - internamento.datai;
                    int nrDias = diferenca.Days;
                    Console.WriteLine($"Data final: {internamento.dataf.ToShortDateString()}");
                    Console.WriteLine($"Nr de dias: {nrDias}");
                }
                Console.WriteLine($"Nr utente de saude: {internamento.nus}");
                Console.WriteLine($"idMédico: {internamento.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os diagnosticos
        /// </summary>
        public void HistoricoDiagnosticos(List<Diagnostico> diagnosticos)
        {
            foreach (Diagnostico diagnostico in diagnosticos)
            {
                Console.WriteLine($"Descricao: {diagnostico.Descricao}");
                Console.WriteLine($"Data: {diagnostico.DataD.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {diagnostico.nus}");
                Console.WriteLine($"idMédico: {diagnostico.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os exames
        /// </summary>
        public void HistoricoExames(List<Exame> exames)
        {
            foreach (Exame exame in exames)
            {
                Console.WriteLine($"Nome: {exame.nome}");
                Console.WriteLine($"Data: {exame.data.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {exame.nus}");
                Console.WriteLine($"idMédico: {exame.MedicoID}");
                Console.WriteLine($"Resultado: {exame.resultado}");
                Console.WriteLine("------------------------------");
            }
        }





    }
}
