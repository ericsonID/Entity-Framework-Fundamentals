using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BookStore.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.Nome).HasMaxLength(30).IsRequired();
            Property(x => x.DataLancamento).IsRequired();
        }

    }
}