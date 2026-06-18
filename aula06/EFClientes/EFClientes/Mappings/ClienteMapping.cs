using EFClientes.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFClientes.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Nome da tabela no banco de dados
            builder.ToTable("CLIENTES");

            //Definir qual é a chave primária da tabela
            builder.HasKey(c => c.Id);

            //Mapear as propriedades da entidade para as colunas do banco de dados
            builder.Property(c => c.Id).HasColumnName("ID");
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(150).IsRequired();
            builder.Property(c => c.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            builder.Property(c => c.DataNascimento).HasColumnName("DATA_NASCIMENTO").IsRequired();
            builder.Property(c => c.NumeroDocumento).HasColumnName("NUMERO_DOCUMENTO").HasMaxLength(25).IsRequired();
            builder.Property(c => c.TipoDocumento).HasColumnName("TIPO_DOCUMENTO").IsRequired();
            builder.Property(c => c.Status).HasColumnName("STATUS").IsRequired();

            //Definir o campo Email como unique
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
