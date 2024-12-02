using AutoMapper;
using LocaMais.App.Cadastros;
using LocaMais.App.Models;
using LocaMais.Domain.Base;
using LocaMais.Domain.Entities;
using LocaMais.Repository.Context;
using LocaMais.Repository.Repository;
using LocaMais.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMais.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();

            #region Banco de Dados
            var strCon = File.ReadAllText(@"C:\Users\bruna\Downloads\POEE\LocaMais\LocaMais.App\Config\ConfigBanco.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Proprietario>, BaseRepository<Proprietario>>();
            Services.AddScoped<IBaseRepository<Inquilino>, BaseRepository<Inquilino>>();
            Services.AddScoped<IBaseRepository<Imovel>, BaseRepository<Imovel>>();
            Services.AddScoped<IBaseRepository<TipoImovel>, BaseRepository<TipoImovel>>();
            Services.AddScoped<IBaseRepository<Contrato>, BaseRepository<Contrato>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Proprietario>, BaseService<Proprietario>>();
            Services.AddScoped<IBaseService<Inquilino>, BaseService<Inquilino>>();
            Services.AddScoped<IBaseService<Imovel>, BaseService<Imovel>>();
            Services.AddScoped<IBaseService<TipoImovel>, BaseService<TipoImovel>>();
            Services.AddScoped<IBaseService<Contrato>, BaseService<Contrato>>();
            #endregion
            
            #region Formulários
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroProprietario, CadastroProprietario>();
            Services.AddTransient<CadastroInquilino, CadastroInquilino>();
            //Services.AddTransient<CadastroImovel, CadastroImovel>();
            Services.AddTransient<CadastroTipoImovel, CadastroTipoImovel>();
            //Services.AddTransient<CadastroContrato, CadastroContrato>();
            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Cidade, CidadeModel>()
                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Proprietario, ProprietarioModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c => c.IdCidade, c => c.MapFrom(x => x.Cidade!.Id));

                config.CreateMap<Inquilino, InquilinoModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c => c.IdCidade, c => c.MapFrom(x => x.Cidade!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
            #endregion

        }
    }
}
