/*
 * Classe Camas
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Objetos;

namespace Dados
{
    public static class Camas
    {
        /// <summary>
        /// Classe Camas
        /// </summary>
        #region ATRIBUTOS

        private static List<Cama> camas = new List<Cama>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Cama , Camas
        /// </summary>
        public static List<Cama> ListadeCamas
        {
            get
            {
                return camas;
            }
            set
            {
                camas = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adicionar uma cama da lista de camas
        /// </summary>

        public static void AdicionarCama(Cama cama)
        {
            camas.Add(cama);
        }



        /// <summary>
        /// Método para remover uma cama da lista de camas
        /// </summary>

        public static void RemoverCama(Cama cama)
        {
            camas.Remove(cama);
        }

        /// <summary>
        /// Método que retorna uma lista estática das camas que estão ocupadas
        /// </summary>
        public static List<Cama> CamasOcupadas()
        {
            return camas.Where(c => c.EstadoCama).ToList();
        }


        /// <summary>
        /// Método que retorna uma lista estática das camas que estão desocupadas
        /// </summary>
        public static List<Cama> CamasDesocupadas()
        {

            return camas.Where(c => !c.EstadoCama).ToList();
        }

        /// <summary>
        /// Método que retorna uma lista estática das camas 
        /// </summary>
        public static List<Cama> ListaCamas()
        {
            return camas;
        }

        /// <summary>
        /// Método que adiciona um paciente á cama
        /// </summary>

        public static void AdicionarPaciente(int nus, int id)
        {
            foreach (var cama in camas) 
            { 
                if(cama.Numerocama == id)
                {
                    if (!cama.EstadoCama)
                    {
                        cama.nus = nus;
                        cama.EstadoCama = true;
                        Console.WriteLine($"O Paciente com o nr utente {nus} associado à cama {cama.Numerocama}.");
                    }
                    else
                    {
                        Console.WriteLine($"A cama {cama.Numerocama} já está ocupada.");
                    }
                }
            }
        }

        /// <summary>
        /// Método que remove um paciente da cama
        /// </summary>
        public static void RemoverPaciente(int nus, int id)
        {
            foreach (var cama in camas)
            {
                if (cama.Numerocama == id)
                {
                    if (cama.EstadoCama)
                    {
                        Console.WriteLine($"Paciente com o nr {nus} removido da cama {cama.Numerocama}.");
                        cama.nus = 0;
                        cama.EstadoCama = true;
                    }
                    else
                    {
                        Console.WriteLine($"A cama {cama.Numerocama} já está desocupada.");
                    }
                }
                    
            }
                
        }

        /// <summary>
        /// Retorna o 1 id que encontra de uma cama vazia
        /// </summary>
        public static int idCamaVazia()
        {
            List<Cama> camas = Camas.CamasDesocupadas();
            return camas.FirstOrDefault().Numerocama;
        }
        #endregion
        #endregion
    }
}
