/*-----------------------------------------------------------------------*
 * Nome do Ficheiro  : Program.cs                                        *
 * Autor             : Hugo Lopes                                        *
 * Data de Criação   : 12/10/2024                                        *
 * Descrição         : Projeto "biblioteca"                              *
 *-----------------------------------------------------------------------*/
using biblioteca;
using System;
using static biblioteca.Tipos_Obras;
using users;

namespace Biblioteca 
{
    #region Classe principal
    /// <summary>
    /// Classe principal que contém o ponto de entrada do programa.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dados de um livro
            Livro livro = new Livro
            {
                Titulo = "C#",
                SubTitulo = "Aprenda em um dia",
                Formato = "Impresso",
                ISBN = "978-3-16-148410-0",
                Lingua = "Português",
                NumeroEdicao = 1,
                AnoPublicacao = 2023,
                Editora = "Editora Info",
                Genero = "Programação",
                N_Ed = "1ª"
            };
            livro.AdicionarAutor("Autor Principal");
            livro.AdicionarAutor("Autor Secundario");
            #endregion

            #region Dados de uma revista
            Revista revista = new Revista
            {
                Titulo = "Nova Gente",
                Formato = "Impressa",
                ISSN = "1234-5678",
                Lingua = "Português",
                NumeroEdicao = 5,
                AnoPublicacao = 2024,
                Editora = "Editora TripleX",
                Genero = "Novelas",
                Periocidade = "Mensal",
                N_Ed = "5ª"
            };
            revista.AdicionarAutor("Fosquinhas");
            #endregion

            #region Dados de um jornal
            Jornal jornal = new Jornal
            {
                Titulo = "Jornal Blitz",
                Formato = "Digital",
                ISSN = "8765-4321",
                Lingua = "Português",
                NumeroEdicao = 12,
                AnoPublicacao = 2024,
                Editora = "Editora Estas_aí",
                Genero = "Música",
                Periocidade = "Semanal",
                N_Ed = "12ª"
            };
            jornal.AdicionarAutor("Slayer");
            #endregion

            #region Mostra as informações das obras
            
            Console.WriteLine("\nObras:");
            Console.WriteLine("------\n");
            Console.WriteLine(livro.Dados_Obras());

            Console.WriteLine("*************************************\n");
            Console.WriteLine(revista.Dados_Obras());
            Console.WriteLine("*************************************\n");
            Console.WriteLine(jornal.Dados_Obras());
            Console.WriteLine("*************************************\n"); ;
            #endregion

            #region Dados dos utilizadores 
            Console.WriteLine("\n\nUtilizadores:");
            Console.WriteLine("-------------\n");
            Tipos_Uti.Aluno aluno = new Tipos_Uti.Aluno(30516, "Hugo Lopes", new DateOnly(1981, 4, 9));

            // Mostra as informações do aluno
            
            Console.WriteLine(aluno.ToString());
            
            
            Tipos_Uti.Professor professor = new Tipos_Uti.Professor(25136, "Ernesto Casanova", new DateOnly(1985, 1, 15));

            // Exibir informações do Professor
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine(professor.ToString());

            // Criar uma instância de Funcionari
            Tipos_Uti.Funcionario funcionario = new Tipos_Uti.Funcionario(78569, "Fátima Coelho", new DateOnly(1975, 3, 26));

            // Exibir informações do Funcionario
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine(funcionario.ToString());
            Console.WriteLine("\n***************************************************************************");
            #endregion
        }
    }
    #endregion
}