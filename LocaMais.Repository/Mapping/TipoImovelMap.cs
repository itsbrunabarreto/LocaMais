using LocaMais.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.Repository.Mapping
{
    public class TipoImovelMap : IEntityTypeConfiguration<TipoImovel>
    {
        public void Configure(EntityTypeBuilder<TipoImovel> builder)
        {
            builder.ToTable("TipoImovel");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
