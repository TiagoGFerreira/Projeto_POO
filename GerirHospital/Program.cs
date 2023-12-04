/*
 * Ficheiro principal do trabalho de POO
 * Tiago
 * a26005@alunos.ipca.pt
 * 06-11-2023
 * POO-LESI
 */


using System;
using Objetos;
using Dados;

namespace GerirHospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Tiago", new DateTime(2004, 8, 19), "Macho");

            Pessoas.AdicionarPessoa(pessoa);


            Pessoas.Listar();
        }
    }
}