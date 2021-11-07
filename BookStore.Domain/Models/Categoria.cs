using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
        public Categoria()
        {
            this.Livros = new List<Livro>();       
        }
        
    }
}