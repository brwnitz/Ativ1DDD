using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnName("CPF")
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.Address)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("varchar(75)");

            builder.Property(prop => prop.CEP)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("CEP")
               .HasColumnType("varchar(8)");
        }
    }
}


