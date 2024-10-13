/*-----------------------------------------------------------------------*
 * Nome do Ficheiro  : Obra.cs                                           *
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
    #region Classe Abstrata Obra
    /// <summary>
    /// A classe Obra é abstrata e representa uma obra genérica, como um livro,
    /// revista ou jornal. Contém propriedades comuns a todas as obras.
    /// </summary>
    public abstract class Obra
    {
        #region Propriedades
        public string Titulo { get; set; }
        public string Formato { get; set; }
        public List<string> Autores { get; set; }
        public string Lingua { get; set; }
        public int NumeroEdicao { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public string N_Ed { get; set; }
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor da classe Obra. Inicializa a lista de autores.
        /// </summary>
        public Obra()
        {
            Autores = new List<string>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona um autor à lista de autores da obra.
        /// </summary>
        /// <param name="autor">Nome do autor a ser adicionado.</param>
        public void AdicionarAutor(string autor)
        {
            Autores.Add(autor);
        }
        /// <summary>
        /// Método abstrato que deve ser implementado pelas classes derivadas
        /// para retornar os dados da obra.
        /// </summary>
        /// <returns>Dados da obra em formato de string.</returns>
        public abstract string Dados_Obras();
        #endregion
    }
    #endregion
}
