using LocaMais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Repository.Mapping
{
    public class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.ValorAluguel)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(prop => prop.DataInicio)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.DataFim)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(prop => prop.Imovel)
                .WithMany()
                .HasForeignKey("ImovelId")
                .IsRequired();

            builder.HasOne(prop => prop.Inquilino)
                .WithMany()
                .HasForeignKey("InquilinoId")
                .IsRequired();

            builder.HasOne(prop => prop.Proprietario)
                .WithMany()
                .HasForeignKey("ProprietarioId")
                .IsRequired();

        }
    }
}
