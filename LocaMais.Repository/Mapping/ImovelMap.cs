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
    public class ImovelMap : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("Imovel");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.PrecoAluguel)
                .IsRequired()
                .HasColumnType("decimal(18,2)"); 

            builder.Property(prop => prop.Disponivel)
                .IsRequired();

            builder.HasOne(prop => prop.Proprietario);

            builder.HasOne(prop => prop.TipoImovel);

            builder.HasOne(prop => prop.Cidade);
                
        }
    }

}
