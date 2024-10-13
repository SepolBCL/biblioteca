/*-----------------------------------------------------------------------*
 * Nome do Ficheiro  : Tipos_Uti.cs                                      *
 * Autor             : Hugo Lopes                                        *
 * Data de Criação   : 12/10/2024                                        *
 * Descrição         : Projeto "biblioteca"                              *
 *-----------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using users;

namespace biblioteca
{
    #region Classe Tipos_Uti
    /// <summary>
    /// A classe Tipos_Uti contém definições de subclasses que representam
    /// diferentes tipos de utilizadores.
    /// </summary>
    public class Tipos_Uti
    {
        #region Classe Aluno
        /// <summary>
        /// Representa um aluno, que deriva da classe Utilizador(library).
        /// </summary>
        public class Aluno : Utilizador
        {
            /// <summary>
            /// Construtor da classe Aluno.
            /// </summary>
            /// <param name="id_U">ID do aluno.</param>
            /// <param name="nome">Nome do aluno.</param>
            /// <param name="dataNascimento">Data de nascimento do aluno.</param>
            public Aluno(int id_U, string nome, DateOnly dataNascimento)
                : base(id_U, nome, dataNascimento) { }

            
            /// <summary>
            /// Retorna uma representação em string do aluno.
            /// </summary>
            /// <returns>String com informações do aluno.</returns>
            public override string ToString()
            {
                return $" Aluno: {Nome}, ID: {Id_U}, Data de Nascimento: {DataNascimento}";
            }

        }
        #endregion

        #region Classe Professor
        /// <summary>
        /// Representa um professor, que deriva da classe Utilizador(library).
        /// </summary>
        public class Professor : Utilizador
        {
            /// <summary>
            /// Construtor da classe Professor.
            /// </summary>
            /// <param name="id_U">ID do professor.</param>
            /// <param name="nome">Nome do professor.</param>
            /// <param name="dataNascimento">Data de nascimento do professor.</param>
            public Professor(int id_U, string nome, DateOnly dataNascimento)
                : base(id_U, nome, dataNascimento) { }

            /// <summary>
            /// Retorna uma representação em string do professor.
            /// </summary>
            /// <returns>String com informações do professor.</returns>
            public override string ToString()
            {
                return $" Professor: {Nome}, ID: {Id_U}, Data de Nascimento: {DataNascimento}";

            }
        }
        #endregion

        #region Classe Funcionario
        /// <summary>
        /// Representa um funcionário, que deriva da classe Utilizador(library).
        /// </summary>
        public class Funcionario : Utilizador
        {
            /// <summary>
            /// Construtor da classe Funcionario.
            /// </summary>
            /// <param name="id_U">ID do funcionário.</param>
            /// <param name="nome">Nome do funcionário.</param>
            /// <param name="dataNascimento">Data de nascimento do funcionário.</param>
            public Funcionario(int id_U, string nome, DateOnly dataNascimento)
                : base(id_U, nome, dataNascimento) { }

            /// <summary>
            /// Retorna uma representação em string do funcionário.
            /// </summary>
            /// <returns>String com informações do funcionário.</returns>
            public override string ToString()
            {
                return $" Funcionário: {Nome}, ID: {Id_U}, Data de Nascimento: {DataNascimento}";
            }
        }
        #endregion

    }
    #endregion
}
