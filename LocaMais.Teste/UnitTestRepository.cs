using LocaMais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocaMais.Teste
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Proprietario> Proprietarios { get; set; }
            public DbSet<Inquilino> Inquilinos { get; set; }
            public DbSet<Imovel> Imoveis { get; set; }
            public DbSet<TipoImovel> TiposImoveis { get; set; }
            public DbSet<Contrato> Contratos { get; set; }
            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "LocaMais";
                var username = "root";
                var password = "BE2505";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]

        public void TestInsertCidades()
        {
            using (var context = new MyDbContext())
            {
                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                cidade = new Cidade
                {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
        }

        [TestMethod]

        public void TestListCidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        [TestMethod]

        public void TestInsertUsuario()
        {
            using (var context = new MyDbContext())
            {


                var usuario = new Usuario
                {
                    Nome = "Bruna",
                    Senha = "Be2505",
                    Login = "barreto",
                    Email = "brunasantosut@gmail.com",
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now,
                    Status = true
                };
                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]

        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]

        public void TestInsertTipoImovel()
        {
            using (var context = new MyDbContext())
            {

                var tipoImovel = new TipoImovel
                {
                    Nome = "Apartamento Duplo",

                };
                context.TiposImoveis.Add(tipoImovel);

                context.SaveChanges();
            }
        }

        [TestMethod]

        public void TestListTipoImovel()
        {
            using (var context = new MyDbContext())
            {
                foreach (var tipoImovel in context.TiposImoveis)
                {
                    Console.WriteLine(JsonSerializer.Serialize(tipoImovel));
                }
            }
        }

        [TestMethod]
        public void TestInsertProprietario()
        {
            using (var context = new MyDbContext())
            {
                var cidade = context.Cidades.FirstOrDefault(c => c.Id == 1);
                var proprietario = new Proprietario
                {
                    Nome = "Bruna Barreto",
                    Cidade = cidade,
                    Cpf = "492.879.538-45",
                    Endereco = "Rua Wilson Troncoso, 579",
                    Bairro = "Toselar",
                    Telefone = "18 98122-4727",
                    Email = "brunasantos@gmail.com"
                };
                context.Proprietarios.Add(proprietario);

                context.SaveChanges();

            }
        }

        [TestMethod]

        public void TestListProprietario()
        {
            using (var context = new MyDbContext())
            {
                foreach (var proprietario in context.Proprietarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(proprietario));
                }
            }
        }

        [TestMethod]
        public void TestInsertInquilino()
        {
            using (var context = new MyDbContext())
            {
                var cidade = context.Cidades.FirstOrDefault(c => c.Id == 1);
                var inquilino = new Inquilino
                {
                    Nome = "Luciana Paulina",
                    Cidade = cidade,
                    Cpf = "478.958.669-80",
                    Endereco = "Rua Wilson Merces, 87",
                    Bairro = "Floresta",
                    Telefone = "18 95879-5845",
                    Email = "lucianapaulina@gmail.com"
                };
                context.Inquilinos.Add(inquilino);

                context.SaveChanges();

            }
        }

        [TestMethod]

        public void TestListInquilino()
        {
            using (var context = new MyDbContext())
            {
                foreach (var proprietario in context.Proprietarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(proprietario));
                }
            }
        }

        [TestMethod]
        public void TestInsertImovel()
        {
            using (var context = new MyDbContext())
            {
                var tipoImovel = context.TiposImoveis.FirstOrDefault(t => t.Id == 1);
                var proprietario = context.Proprietarios.FirstOrDefault(p => p.Id == 1); 
                var cidade = context.Cidades.FirstOrDefault(c => c.Id == 1);

                var imovel = new Imovel
                {
                    Nome = "Apartamento Central",
                    Endereco = "Rua Exemplo, 123",
                    PrecoAluguel = 1500.00f,
                    Disponivel = true,
                    Proprietario = proprietario,
                    TipoImovel = tipoImovel,
                    Cidade = cidade
                };

                context.Imoveis.Add(imovel);

                context.SaveChanges();
            }
        }

        [TestMethod]

        public void TestListImovel()
        {
            using (var context = new MyDbContext())
            {
                foreach (var imovel in context.Imoveis)
                {
                    Console.WriteLine(JsonSerializer.Serialize(imovel));
                }
            }
        }

        [TestMethod]
        public void TestInsertContrato()
        {
            using (var context = new MyDbContext())
            {
                var imovel = context.Imoveis.FirstOrDefault(i => i.Id == 1); 
                var inquilino = context.Inquilinos.FirstOrDefault(i => i.Id == 1); 
                var proprietario = context.Proprietarios.FirstOrDefault(p => p.Id == 1); 

                var contrato = new Contrato
                {
                    DataInicio = new DateTime(2024, 12, 01),
                    DataFim = new DateTime(2025, 12, 01),
                    ValorAluguel = 1200.00f,
                    Imovel = imovel,
                    Inquilino = inquilino,
                    Proprietario = proprietario
                };

                context.Contratos.Add(contrato);
                context.SaveChanges();
            }
        }

        [TestMethod]

        public void TestListContrato()
        {
            using (var context = new MyDbContext())
            {
                foreach (var contrato in context.Contratos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(contrato));
                }
            }
        }


    }
}
