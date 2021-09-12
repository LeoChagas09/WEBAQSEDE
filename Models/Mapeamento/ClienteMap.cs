using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAQSEDE.Models.Dominio;

namespace WEBAQSEDE.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CPF).HasMaxLength(20).IsRequired();
            builder.HasIndex(p => p.CPF).IsUnique();
            builder.Property(p => p.DataNascimento).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CEP).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Endereco).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Telefone).HasMaxLength(20).IsRequired();
        }
    }
}
