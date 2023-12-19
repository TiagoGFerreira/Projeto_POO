/*
 * Ficheiro principal do trabalho de POO
 * Tiago
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */

using Objetos;
using Regras;
using System;
using System.Collections.Generic;

namespace GerirHospital
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Criar Instancias

            /// <summary>
            /// Criação Instâncias da classe Pessoa
            /// </summary>
            Pessoa Tiago = new Pessoa("Tiago", new DateTime(2004, 08, 19), "Masculino");
            Pessoa Juliana = new Pessoa("Juliana", new DateTime(2004, 03, 26), "Feminino");
            Pessoa Diogo = new Pessoa("Diogo", new DateTime(1997, 06, 05), "Masculino");
            Pessoa Joao = new Pessoa("Joao", new DateTime(1994, 01, 09), "Masculino");

            /// <summary>
            /// Criação Instâncias da classe Paciente
            /// </summary>
            Paciente Paciente1 = new Paciente(234135678, Tiago);
            Paciente Paciente2 = new Paciente(657898762, Juliana);

            /// <summary>
            /// Criação Instâncias da classe Médico
            /// </summary>
            Medico Medico1 = new Medico(Diogo, EspecialidadeMedica.Cardiologia);
            Medico Medico2 = new Medico(Joao, EspecialidadeMedica.Neurologia);

            /// <summary>
            /// Criação Instâncias da classe Consulta
            /// </summary>
            Consulta Consulta1 = new Consulta(1, 234135678, new DateTime(2024, 12, 18), "Cardiologia");
            Consulta Consulta2 = new Consulta(1, 234135678, new DateTime(2024, 08, 19), "Rotina");
            Consulta Consulta3 = new Consulta(2, 657898762, new DateTime(2024, 01, 10), "Neurologia");

            /// <summary>
            /// Criação Instâncias da classe Exame
            /// </summary>
            Exame Exame1 = new Exame("Cardio", "Tudo ok", 657898762, 1, new DateTime(2024, 12, 18));
            Exame Exame2 = new Exame("Neurologia", "Detado Alteracoes", 234135678, 2, new DateTime(2024, 01, 10));

            /// <summary>
            /// Criação Instâncias da classe Internamento
            /// </summary>
            Internamento Internamento = new Internamento("Cirugia", 2, 657898762, new DateTime(2024, 01, 11));

            /// <summary>
            /// Criação Instâncias da classe Diagnostico
            /// </summary>
            Diagnostico Diagnostico = new Diagnostico("diagnostico", 2, 657898762, new DateTime(2024, 01, 10));

            Cama Cama1 = new Cama();
            Cama Cama2 = new Cama();
            #endregion

            #region Adicionar Objetos nas Listas

            RegrasHospital.AdicionarPaciente(Paciente1);
            RegrasHospital.AdicionarPaciente(Paciente2);

            RegrasHospital.AdicionarMedico(Medico1);
            RegrasHospital.AdicionarMedico(Medico2);

            RegrasHospital.AdicionarConsulta(Consulta1);
            RegrasHospital.AdicionarConsulta(Consulta2);
            RegrasHospital.AdicionarConsulta(Consulta3);

            RegrasHospital.AdicionarExame(Exame1);
            RegrasHospital.AdicionarExame(Exame2);

            RegrasHospital.AdicionarCama(Cama1);
            RegrasHospital.AdicionarCama(Cama2);

            RegrasHospital.AdicionarInternamento(Internamento);

            List<Internamento> internamentos1 = RegrasHospital.ListaInternamento();
            int i = internamentos1.Count;

            RegrasHospital.AdicionarDiagnostico(Diagnostico);

            #endregion

            #region OtherThings

            /// <summary>
            /// Chamada do método AtualizarInternamento de forma a atribuir-lhe uma data final
            /// </summary>
            RegrasHospital.AtualizarInternamento(Internamento, new DateTime(2024, 01, 15));

            /// <summary>
            /// Chamada do método para adicionar doencas ao paciente
            /// </summary>
            RegrasHospital.AdicionarDoenca(Paciente2, "Insuficienca Cardiaca");
            RegrasHospital.AdicionarDoenca(Paciente2, "Diabetes");

            /// <summary>
            /// Chamada do método que retorna a lista atual de pacientes e com isso imprimir as doencas do paciente
            /// </summary>
            List<Paciente> pacientes = RegrasHospital.ListaPacientes();
            IO.DoencasPaciente(657898762, pacientes);

            /// <summary>
            /// Chamada do método que retorna a lista atual de internamentos e com isso imprimir o historico de internamentos
            /// </summary>
            List<Internamento> internamentos = RegrasHospital.ListaInternamento();
            IO.HistoricoInternamentos(internamentos);

            #endregion

            #region Guardar / Carregar Pacientes

            RegrasHospital.CarregarPacientes("ficheiro.bin");

            List<Paciente> Pacientes = RegrasHospital.ListaPacientes();

            #endregion

            #region Custo
            double custo = RegrasHospital.CustoTotal(657898762, new DateTime(2024, 01, 11), new DateTime(2024, 01, 16));
            IO.ImprimeCusto(custo, 657898762);
            #endregion

        }
    }
}