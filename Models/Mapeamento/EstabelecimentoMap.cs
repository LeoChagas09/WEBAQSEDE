using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAQSEDE.Models.Dominio;

namespace WEBAQSEDE.Models.Mapeamento
{
    public class EstabelecimentoMap : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CNPJ).HasMaxLength(20).IsRequired();
            builder.HasIndex(p => p.CNPJ).IsUnique();
            builder.Property(p => p.Email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CEP).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Endereco).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Telefone).HasMaxLength(20).IsRequired();
        }
    }
}
