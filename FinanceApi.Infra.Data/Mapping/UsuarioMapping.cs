using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceApi.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.Property(x => x.Id)
            .IsUnicode();
            builder.Property(x => x.Nome);
            builder.Property(x => x.Idade);
            builder.Property(x => x.Cpf)
            .IsUnicode();
            builder.Property(x => x.Saldo);
        }
    }
}