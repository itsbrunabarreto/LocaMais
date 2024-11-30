using LocaMais.Domain.Entities;
using LocaMais.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace LocaMais.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Inquilino> Inquilinos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<TipoImovel> TiposImoveis { get; set; }
        public DbSet<Contrato> Contratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Proprietario>(new ProprietarioMap().Configure);
            modelBuilder.Entity<Inquilino>(new InquilinoMap().Configure);
            modelBuilder.Entity<Imovel>(new ImovelMap().Configure);
            modelBuilder.Entity<TipoImovel>(new TipoImovelMap().Configure);
            modelBuilder.Entity<Contrato>(new ContratoMap().Configure);

        }
    }
}
