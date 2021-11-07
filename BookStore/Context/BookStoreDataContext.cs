using BookStore.Domain;
using BookStore.Mapping;
using System.Data.Entity;

namespace BookStore.Context
{
    public class BookStoreDataContext :DbContext
    {
        
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Caterogias { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public BookStoreDataContext()
            :base("BookStoreConnectionString") 
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());

        }
    }
}