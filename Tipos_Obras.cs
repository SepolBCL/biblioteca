/*-----------------------------------------------------------------------*
 * Nome do Ficheiro  : Tipos_Obras.cs                                    *
 * Autor             : Hugo Lopes                                        *
 * Data de Criação   : 12/10/2024                                        *
 * Descrição         : Projeto "biblioteca"                              *
 *-----------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    #region Classe Tipos_Obras
    /// <summary>
    /// A classe Tipos_Obras contém definições de subclasses que representam
    /// diferentes tipos de obras..
    /// </summary>
    public class Tipos_Obras
    {
        #region Classe Livro
        /// <summary>
        /// Representa um livro, que herda da classe abstrata Obra alguns requesitos
        /// e acrescenta outros.
        /// </summary>
        public class Livro : Obra
        {
            public string ISBN { get; set; }
            public string SubTitulo { get; set; }

            /// <summary>
            /// Retorna os dados do livro formatados como uma string.
            /// </summary>
            /// <returns>String com informações do livro.</returns>
            public override string Dados_Obras()
            {
                return $"Livro\n\n" +
                       $"Título: {Titulo}\n" +
                       $"Subtítulo: {SubTitulo}\n" +
                       $"Formato: {Formato}\n" +
                       $"ISBN: {ISBN}\n" +
                       $"Autores: {string.Join(", ", Autores)}\n" +
                       $"Língua: {Lingua}\n" +
                       $"Número da Edição: {NumeroEdicao}\n" +
                       $"Ano de Publicação: {AnoPublicacao}\n" +
                       $"Editora: {Editora}\n" +
                       $"Gênero: {Genero}\n" +
                       $"Número da Edição : {N_Ed}\n"; 
            }

           
        }
        #endregion

        #region Classe Revista
        /// <summary>
        /// Representa uma revista, herda da classe abstrata Obra alguns requesitos
        /// e acrescenta outros.
        /// </summary>
        public class Revista : Obra 
        {
            public string ISSN { get; set; }
            public string Periocidade {  get; set; }
            /// <summary>
            /// Retorna os dados da revista formatados como uma string.
            /// </summary>
            /// <returns>String com informações da revista.</returns>
            public override string Dados_Obras()
            {
                return $"Revista\n\n" +
                       $"Título: {Titulo}\n" +
                       $"Formato: {Formato}\n" +
                       $"ISSN: {ISSN}\n" +
                       $"Autores: {string.Join(", ", Autores)}\n" +
                       $"Língua: {Lingua}\n" +
                       $"Número da Edição: {NumeroEdicao}\n" +
                       $"Ano de Publicação: {AnoPublicacao}\n" +
                       $"Editora: {Editora}\n" +
                       $"Gênero: {Genero}\n" +
                       $"Periocidade: {Periocidade}\n" +
                       $"Número da Edição : {N_Ed}\n";
            }
             
        }
        #endregion

        #region Classe Jornal
        /// <summary>
        /// Representa um jornal, herda da classe abstrata Obra alguns requesitos
        /// e acrescenta outros.
        /// </summary>
        public class Jornal : Obra
        {
            public string ISSN { get; set; }
            public string Periocidade { get;set; }
            /// <summary>
            /// Retorna os dados do jornal formatados como uma string.
            /// </summary>
            /// <returns>String com informações do jornal.</returns>
            public override string Dados_Obras()
            {
                return $"Jornal\n\n" +
                       $"Título: {Titulo}\n" +
                       $"Formato: {Formato}\n" +
                       $"ISSN: {ISSN}\n" +
                       $"Autores: {string.Join(", ", Autores)}\n" +
                       $"Língua: {Lingua}\n" +
                       $"Número da Edição: {NumeroEdicao}\n" +
                       $"Ano de Publicação: {AnoPublicacao}\n" +
                       $"Editora: {Editora}\n" +
                       $"Gênero: {Genero}\n" +
                       $"Periocidade: {Periocidade}\n" +
                       $"Número da Edição : {N_Ed}\n";
            }
        }
            #endregion
     }   
    #endregion
        
    
}
