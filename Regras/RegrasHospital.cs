/*
 * Classe RegrasHospital
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */

using Objetos;
using Dados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Regras
{
    /// <summary>
    /// Classe RegrasHospital
    /// </summary>
    public class RegrasHospital
    {
        #region Métodos Pessoa
        /// <summary>
        /// Método para adicionar uma pessoa da lista de pessoas
        /// </summary>
        public static bool AdicionarPessoa(Pessoa pessoa)
        {
            if(pessoa != null)
            {
                Pessoas.AdicionarPessoa(pessoa);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma pessoa da lista de pessoas
        /// </summary>
        public static bool RemoverPessoaLista(Pessoa pessoa)
        {
            if (ListaPessoas().Contains(pessoa))
            {
                Pessoas.RemoverPessoa(pessoa);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da class estática Pessoas
        /// </summary>
        public static List<Pessoa> ListaPessoas()
        {
            return Pessoas.ListaPessoas();
        }
        #endregion

        #region Métodos Paciente
        // <summary>
        /// Método para adicionar um paciente da lista de pacientes
        /// </summary>
        public static bool AdicionarPaciente(Paciente paciente)
        {
            if (paciente != null)
            {
                Pacientes.AdicionarPaciente(paciente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente da lista de pacientes
        /// </summary>
        public static bool RemoverPaciente(Paciente paciente)
        {
            if (ListaPacientes().Contains(paciente))
            {
                Pacientes.RemoverPaciente(paciente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da class estática Pacientes
        /// </summary>
        public static List<Paciente> ListaPacientes()
        {
            return Pacientes.ListaPacientes();
        }


        /// <summary>
        /// Retorna o objeto paciente de acordo com o seu Nr de utentne
        /// </summary>
        public static Paciente ObterPacientePorNUS(int nus)
        {
            //Fazer excepiton para verificar NUS
            return Pacientes.ObterPacientePorNUS(nus);
        }
        #endregion

        #region Métodos Médico
        // <summary>
        /// Método para adicionar um medico da lista de medicos
        /// </summary>
        public static bool AdicionarMedico(Medico medico)
        {
            if (medico != null)
            {
                Medicos.AdicionarMedico(medico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um medico da lista de medicos
        /// </summary>
        public static bool RemoverMedico(Medico medico)
        {
            if (ListaMedicos().Contains(medico))
            {
                Medicos.RemoverMedico(medico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da class estática Medicos
        /// </summary>
        public static List<Medico> ListaMedicos()
        {
            return Medicos.ListaMedicos();
        }


        /// <summary>
        /// Retorna o objeto paciente de acordo com o seu id
        /// </summary>
        public static Medico ObterMedicoPorID(int id)
        {
            //Fazer excepiton para verificar NUS
            return Medicos.ObterMedicoPorId(id);
        }
        #endregion

        #region Métodos Internamento
        /// <summary>
        /// Método que adiciona a data final ao internamento
        /// </summary>
        public static bool AtualizarInternamento(Internamento internamento, DateTime dataFim)
        {
            foreach (var item in Internamentos.ListaInternamento())
            {
                if (item == internamento)
                {
                    Internamento.FimInternamento(internamento, dataFim); 
                    return true; 
                }
            }
            return false; 
        }

        // <summary>
        /// Método para adicionar um internamento da lista de internamentos
        /// </summary>
        public static bool AdicionarInternamento(Internamento internamento)
        {
            if (internamento != null)
            {
                Internamentos.AdicionarInternamento(internamento);
                AdicionarPacienteCama(internamento.nus, Camas.idCamaVazia());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um internamento da lista de internamentos
        /// </summary>
        public static bool RemoverInternamento(Internamento internamento)
        {
            if (ListaInternamento().Contains(internamento))
            {
                Internamentos.RemoverInternamento(internamento);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática Internamentos
        /// </summary>
        public static List<Internamento> ListaInternamento()
        {
            return Internamentos.ListaInternamento(); 
        }
        #endregion

        #region Métodos Exames
        /// <summary>
        /// Método para adicionar um exame da lista de exame
        /// </summary>
        public static bool AdicionarExame(Exame exame)
        {
            if (exame != null)
            {
                Exames.AdicionarExame(exame);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um exame da lista de exames
        /// </summary>
        public static bool RemoverExame(Exame exame)
        {
            if (ListaExames().Contains(exame))
            {
                Exames.RemoverExame(exame);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática Exames
        /// </summary>
        public static List<Exame> ListaExames()
        {
            return Exames.ListaExames();
        }
        #endregion

        #region Métodos Diagnósticos
        /// <summary>
        /// Método para adicionar um diagnostico da lista de diagnosticos
        /// </summary>
        public static bool AdicionarDiagnostico(Diagnostico diagnostico)
        {
            if (diagnostico != null)
            {
                Diagnosticos.AdicionarDiagnostico(diagnostico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um diagnostico da lista de diagnosticos
        /// </summary>
        public static bool RemoverDiagnostico(Diagnostico diagnostico)
        {
            if (ListaDiagnosticos().Contains(diagnostico))
            {
                Diagnosticos.RemoverDiagnostico(diagnostico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática Diagnósticos
        /// </summary>
        public static List<Diagnostico> ListaDiagnosticos()
        {
            return Diagnosticos.ListaDiagnosticos();
        }
        #endregion

        #region Métodos Consulta 
        /// <summary>
        /// Método para adicionar uma consulta da lista de consultas
        /// </summary>
        public static bool AdicionarConsulta(Consulta consulta)
        {
            if (consulta != null)
            {
                Consultas.AdicionarConsulta(consulta);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma consulta da lista de consultas
        /// </summary>
        public static bool RemoverConsulta(Consulta consulta)
        {
            if (ListaConsultas().Contains(consulta))
            {
                Consultas.RemoverConsulta(consulta);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática Consultas
        /// </summary>
        public static List<Consulta> ListaConsultas()
        {
            return Consultas.ListaConsultas();
        }
        #endregion

        #region Métodos Cirurgias
        /// <summary>
        /// Método para adicionar uma cirurgia da lista de cirurgias
        /// </summary>
        public static bool AdicionarCirurgia(Cirurgia cirurgia)
        {
            if (cirurgia != null)
            {
                Cirurgias.AdicionarCirurgia(cirurgia);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma cirurgia da lista de cirurgias
        /// </summary>
        public static bool RemoverCirurgia(Cirurgia cirurgia)
        {
            if (ListaCirurgias().Contains(cirurgia))
            {
                Cirurgias.RemoverCirurga(cirurgia);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática Cirurgias
        /// </summary>
        public static List<Cirurgia> ListaCirurgias()
        {
            return Cirurgias.ListaCirurgias();
        }
        #endregion Cirurgias

        #region Métodos Camas
        /// <summary>
        /// Método para adicionar uma cama da lista de camas
        /// </summary>
        public static bool AdicionarCama(Cama cama)
        {
            if (cama != null)
            {
                Camas.AdicionarCama(cama);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma cama da lista de camas
        /// </summary>
        public static bool RemoverCama(Cama cama)
        {
            if (ListaCamas().Contains(cama))
            {
                Camas.RemoverCama(cama);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática camas
        /// </summary>
        public static List<Cama> ListaCamas()
        {
            return Camas.ListaCamas();
        }

        /// <summary>
        /// Método que adiciona paciente na cama
        /// </summary>
        public static bool AdicionarPacienteCama(int nus, int id)
        {
            //excption NUS
            Camas.AdicionarPaciente(nus, id);
            return true;
        }

        /// <summary>
        /// Método que remove paciente na cama
        /// </summary>
        public static bool RemoverPacienteCama(int nus, int id)
        {
            //excption NUS
            Camas.RemoverPaciente(nus, id);
            return true;

        }
        #endregion

        #region Métodos Custos
        /// <summary>
        /// Método para adicionar um custo da lista de custos
        /// </summary>
        public static bool AdicionarCusto(Custo custo)
        {
            if (custo != null)
            {
                Custos.AdicionarCusto(custo);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um custo da lista de custos
        /// </summary>
        public static bool RemoverCusto(Custo custo)
        {
            if (ListaCustos().Contains(custo))
            {
                Custos.RemoverCusto(custo);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a lista da classe estática custos
        /// </summary>
        public static List<Custo> ListaCustos()
        {
            return Custos.ListaCustos();
        }


        /// <summary>
        /// Método que retorna o custo final do serviços prestados ao cliente
        /// </summary>º
        public static double CustoTotal(int nus, DateTime dataI, DateTime dataF)
        {
            if(dataI <= DateTime.Now &&  dataF <= DateTime.Now)
            {
                return Custos.CustoTotal(nus, dataI, dataF);
            }
            return 0;
        }
        #endregion
    }
}
