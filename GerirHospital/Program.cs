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
          
            Pessoa pessoa = new Pessoa("Tiago", new DateTime(2004, 08, 19), "Masculino");
            Pessoa pessoa1 = new Pessoa("Joao", new DateTime(2004, 08, 19), "Masculino");
            // Criar um objeto Pessoa

            Paciente paciente1 = new Paciente(256758498, pessoa);

            Medico medico = new Medico(pessoa1, "Cardiologia");

            Internamento internamento = new Internamento("cirugia", 1, 256758498, new DateTime(2023, 10, 11));

            Exame exame = new Exame("Cardio", "Bom", 256758498, 1, new DateTime(2023, 10, 11));

            Diagnostico diagnostico = new Diagnostico("diagnostico", 1, 256758498, new DateTime(2023, 10, 11));

            Consulta consulta = new Consulta(1, 256758498, new DateTime(2023, 10, 11), "cardio");

            Cama cama = new Cama();


            
            RegrasHospital.AdicionarPessoa(pessoa);
            RegrasHospital.AdicionarPessoa(pessoa1);

            List<Pessoa> pessoas = RegrasHospital.ListaPessoas();

            RegrasHospital.AdicionarPaciente(paciente1);
            RegrasHospital.AdicionarMedico(medico);
            RegrasHospital.AdicionarConsulta(consulta);
            RegrasHospital.AdicionarDiagnostico(diagnostico);
            RegrasHospital.AdicionarExame(exame);
            RegrasHospital.AdicionarCama(cama);
            RegrasHospital.AdicionarInternamento(internamento);
            RegrasHospital.AtualizarInternamento(internamento, new DateTime(2023, 10, 16));
          
            

            double custo = RegrasHospital.CustoTotal(256758498, new DateTime(2023, 10, 11), new DateTime(2023, 10, 16)); 
            Console.WriteLine(custo);
        }
    }
}