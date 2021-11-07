using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Autor
    {  
        public int  Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
        public Autor()
        {
            this.Livros = new List<Livro>();
        }
    }
}