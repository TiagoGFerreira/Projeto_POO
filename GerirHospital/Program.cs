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
          
            Pessoa pessoa = new Pessoa("Tiago", new DateTime(2004, 08, 19), "Feminino");
            Pessoa pessoa1 = new Pessoa("Joao", new DateTime(2004, 08, 19), "Masculino");

            Paciente paciente1 = new Paciente(234135678, pessoa1);

           



            RegrasHospital.AdicionarPaciente(paciente1);

            Medico medico = new Medico(pessoa1, EspecialidadeMedica.Cardiologia);
            Medico medico1 = new Medico(pessoa1, EspecialidadeMedica.Cardiologia);

            Internamento internamento = new Internamento("cirugia", 1, 234135678, new DateTime(2024, 12, 18));
            Console.WriteLine(internamento.dataf);

            Exame exame = new Exame("Cardio", "Bom", 234135678, 1, new DateTime(2024, 12, 18));

            Diagnostico diagnostico = new Diagnostico("diagnostico", 1, 234135678, new DateTime(2024, 12, 18));

            Consulta consulta = new Consulta(1, 234135678, new DateTime(2024, 12, 18), "cardio");

            Cama cama = new Cama();

            //CORRIGIR ERRO
            //Cirurgia cirurgia = new Cirurgia("teste", 1, 256758498, new DateTime(2023, 10, 11));
            
            RegrasHospital.AdicionarPessoa(pessoa);
            RegrasHospital.AdicionarPessoa(pessoa1);

            List<Pessoa> pessoas = RegrasHospital.ListaPessoas();

            //RegrasHospital.AdicionarPaciente(paciente1);
            RegrasHospital.AdicionarMedico(medico);
            RegrasHospital.AdicionarMedico(medico1);
            RegrasHospital.AdicionarConsulta(consulta);
            RegrasHospital.AdicionarDiagnostico(diagnostico);
            RegrasHospital.AdicionarExame(exame);
            RegrasHospital.AdicionarCama(cama);
            RegrasHospital.AdicionarInternamento(internamento);
            RegrasHospital.AtualizarInternamento(internamento, new DateTime(2024, 10, 21));



            List<Consulta> consultas = RegrasHospital.ListaConsultas();
            IO.MostrarConsultasMedico(consultas, 1);

            double custo = RegrasHospital.CustoTotal(234135678, new DateTime(2024, 10, 11), new DateTime(2024, 10, 16));


            IO.MostrarConsultasMedico(RegrasHospital.ListaConsultas(), 1);



            List<Paciente> pacientess = RegrasHospital.ListaPacientes();



            RegrasHospital.GuardarPacientes("ficheiro.bin");


            if (RegrasHospital.CarregarPacientes("ficheiro.bin")) Console.WriteLine("FEITO");
            {
                List<Paciente> pacientes = RegrasHospital.ListaPacientes();
                foreach (Paciente paciente in pacientes)
                {
                    Console.WriteLine(paciente.Sexo);
                }
            }
        }
    }
}