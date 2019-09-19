using EntityCore.Models.BusinessModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Models.BusinessModels
{
    public class Context:DbContext

    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "server=localhost;port=3306;user id=root;password=root;database=teste; allowzerodatetime=True; convertzerodatetime=True";
            builder
                .UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Id)                                      
                    .HasColumnName("Id")
                    .HasColumnType("bigint(20)");
                
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("Nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                   .HasColumnName("Status")
                   .HasColumnType("tinyint(1)");
            });

            builder.Entity<Endereco>(entity =>
            {
                entity.HasIndex(e => e.IdPessoa)
                    .HasName("fk_endereco_pessoa");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Status)
                   .HasColumnName("Status")
                   .HasColumnType("tinyint(1)");

                entity.Property(e => e.Logradouro)
                    .HasColumnName("Logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("Numero")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasColumnName("Complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .HasColumnName("Bairro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasColumnName("Cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("Estado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasColumnName("Pais")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("Cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_endereco_pessoa");
            });
        }
    }
}
