using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAQSEDE.Models.Dominio;

namespace WEBAQSEDE.Models.Mapeamento
{
    public class EntregadorMap : IEntityTypeConfiguration<Entregador>
    {
        public void Configure(EntityTypeBuilder<Entregador> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CPF).HasMaxLength(20).IsRequired();
            builder.HasIndex(p => p.CPF).IsUnique();
            builder.Property(p => p.DataNascimento).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CEP).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CNH).HasMaxLength(20).IsRequired();
            builder.HasIndex(p => p.CNH).IsUnique();
            builder.Property(p => p.Telefone).HasMaxLength(20).IsRequired();
        }
    }
}
