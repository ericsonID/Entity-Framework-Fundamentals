using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BookStore.Mapping
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired(); ;
            HasMany(x => x.Livros)
                .WithMany(x => x.Autores)
                .Map(x=>x.ToTable("LivroAutor"));
        }

    }
}