using AutoMapper;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Repository.Context;
using LocaMais.Repository.Repository;
using LocaMais.Service.Services;
using LocaMais.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.RegularExpressions;


namespace LocaMais.Teste
{
    [TestClass]

    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "LocaMais";
                var username = "root";
                var password = "BE2505";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, Usuario>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cidade, Cidade>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Proprietario>, BaseRepository<Proprietario>>();
            services.AddScoped<IBaseService<Proprietario>, BaseService<Proprietario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Proprietario, Proprietario>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Inquilino>, BaseRepository<Inquilino>>();
            services.AddScoped<IBaseService<Inquilino>, BaseService<Inquilino>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Inquilino, Inquilino>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Imovel>, BaseRepository<Imovel>>();
            services.AddScoped<IBaseService<Imovel>, BaseService<Imovel>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Imovel, Imovel>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<TipoImovel>, BaseRepository<TipoImovel>>();
            services.AddScoped<IBaseService<TipoImovel>, BaseService<TipoImovel>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<TipoImovel, TipoImovel>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Contrato>, BaseRepository<Contrato>>();
            services.AddScoped<IBaseService<Contrato>, BaseService<Contrato>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Contrato, Contrato>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]

        public void TestInsertCidade()
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade
            {
                Nome = "Birigui",
                Estado = "SP"
            };

            var result = cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertTipoImovel()
        {
            var sp = ConfigureServices();
            var tipoImovelService = sp.GetService<IBaseService<TipoImovel>>();
            var tipoImovel = new TipoImovel()
            {
                Nome = "Apartamento Duplo"
            };

            var result = tipoImovelService.Add<TipoImovel, TipoImovel, TipoImovelValidator>(tipoImovel);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Bruna Barreto",
                Login = "bsb",
                Email = "bruna@gmail.com",
                Senha = "Be250500!",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Now
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertProprietario()
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = cidadeService.Get<Cidade>().FirstOrDefault(c => c.Id >= 1);
            var proprietarioService = sp.GetService<IBaseService<Proprietario>>();
            var proprietario = new Proprietario()
            {
                Nome = "Bruna",
                Endereco = "Rua Wilson Troncoso",
                Bairro = "Residencial Alvorada",
                Cpf = "47816993880",
                Telefone = "18994789865",
                Email = "brunasantos@gmail.com",
                Cidade = cidade
            };

            var result = proprietarioService.Add<Proprietario, Proprietario, ProprietarioValidator>(proprietario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]

        public void TestInsertInquilino()
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = cidadeService.Get<Cidade>().FirstOrDefault(c => c.Id >= 1);
            var inquilinoService = sp.GetService<IBaseService<Inquilino>>();
            var inquilino = new Inquilino()
            {
                Nome = "Luciana",
                Endereco = "Rua Mendes Habib",
                Bairro = "Residencial Horizonte",
                Cpf = "47562548779",
                Telefone = "18978989865",
                Email = "lucianasantos@gmail.com",
                Cidade = cidade
            };

            var result = inquilinoService.Add<Inquilino, Inquilino, InquilinoValidator>(inquilino);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertImovel()
        {
            var sp = ConfigureServices();
            var proprietarioService = sp.GetService<IBaseService<Proprietario>>();
            var proprietario = proprietarioService.Get<Proprietario>().FirstOrDefault(p => p.Id >= 1);

            var tipoImovelService = sp.GetService<IBaseService<TipoImovel>>();
            var tipoImovel = tipoImovelService.Get<TipoImovel>().FirstOrDefault(t => t.Id >= 1);

            var cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade= cidadeService.Get<Cidade>().FirstOrDefault(i => i.Id >= 1);

            var imovelService = sp.GetService<IBaseService<Imovel>>();

            var imovel = new Imovel()
            {
                Nome = "Apartamento Patrimonio Silvares",
                Endereco = "Rua Exemplo, 123",
                PrecoAluguel = 1500.00f,
                Disponivel = true,
                Proprietario = proprietario,
                TipoImovel = tipoImovel,
                Cidade = cidade
            };

            var result = imovelService.Add<Imovel, Imovel, ImovelValidator>(imovel);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertContrato()
        {
            var sp = ConfigureServices();
            var imovelService = sp.GetService<IBaseService<Imovel>>();
            var imovel = imovelService.Get<Imovel>().FirstOrDefault(i => i.Id >= 1);

            var inquilinoService = sp.GetService<IBaseService<Inquilino>>();
            var inquilino = inquilinoService.Get<Inquilino>().FirstOrDefault(i => i.Id >= 1);

            var proprietarioService = sp.GetService<IBaseService<Proprietario>>();
            var proprietario = proprietarioService.Get<Proprietario>().FirstOrDefault(p => p.Id >= 1);

            var contratoService = sp.GetService<IBaseService<Contrato>>();

            var contrato = new Contrato()
            {
                DataInicio = new DateTime(2024, 12, 01),
                DataFim = new DateTime(2025, 12, 01),
                ValorAluguel = 1200.00f,
                Imovel = imovel,
                Inquilino = inquilino,
                Proprietario = proprietario
            };

            var result = contratoService.Add<Contrato, Contrato, ContratoValidator>(contrato);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = usuarioService.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectCidade()
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();

            var result = cidadeService.Get<Cidade>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectTipoImovel()
        {
            var sp = ConfigureServices();
            var tipoImovelService = sp.GetService<IBaseService<TipoImovel>>();

            var result = tipoImovelService.Get<TipoImovel>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectProprietario()
        {
            var sp = ConfigureServices();
            var proprietarioService = sp.GetService<IBaseService<Proprietario>>();

            var result = proprietarioService.Get<Proprietario>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectInquilino()
        {
            var sp = ConfigureServices();
            var inquilinoService = sp.GetService<IBaseService<Inquilino>>();

            var result = inquilinoService.Get<Inquilino>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectImovel()
        {
            var sp = ConfigureServices();
            var imovelService = sp.GetService<IBaseService<Imovel>>();

            var result = imovelService.Get<Imovel>();
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectContrato()
        {
            var sp = ConfigureServices();
            var contratoService = sp.GetService<IBaseService<Contrato>>();

            var result = contratoService.Get<Contrato>();
            Console.Write(JsonSerializer.Serialize(result));

        }
    }
}
