using AutoMapper;
using LocaMais.App.Cadastros;
using LocaMais.App.Models;
using LocaMais.App.Outros;
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
            var strCon = File.ReadAllText(@"Config\ConfigBanco.txt");

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
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroProprietario, CadastroProprietario>();
            Services.AddTransient<CadastroInquilino, CadastroInquilino>();
            Services.AddTransient<CadastroImovel, CadastroImovel>();
            Services.AddTransient<CadastroTipoImovel, CadastroTipoImovel>();
            Services.AddTransient<CadastroContrato, CadastroContrato>();
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

                config.CreateMap<TipoImovel, TipoImovelModel>()
                .ForMember(c => c.Nome, c => c.MapFrom(x => x.Nome));

                config.CreateMap<Imovel, ImovelModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c => c.IdCidade, c => c.MapFrom(x => x.Cidade!.Id))  
                .ForMember(c => c.TipoImovel, c => c.MapFrom(x => x.TipoImovel!.Nome))
                .ForMember(c => c.IdTipoImovel, c => c.MapFrom(x => x.TipoImovel!.Id))
                .ForMember(c => c.Proprietario, c => c.MapFrom(x => x.Proprietario!.Nome))
                .ForMember(c => c.IdProprietario, c => c.MapFrom(x => x.Proprietario!.Id));

                config.CreateMap<Contrato, ContratoModel>()
               .ForMember(c => c.Inquilino, c => c.MapFrom(x => x.Inquilino!.Nome))
               .ForMember(c => c.IdInquilino, c => c.MapFrom(x => x.Inquilino!.Id))
               .ForMember(c => c.Proprietario, c => c.MapFrom(x => x.Proprietario!.Nome))
               .ForMember(c => c.IdProprietario, c => c.MapFrom(x => x.Proprietario!.Id))
               .ForMember(c => c.Imovel, c => c.MapFrom(x => x.Imovel!.Nome))
               .ForMember(c => c.IdImovel, c => c.MapFrom(x => x.Imovel!.Id))
               .ForMember(c => c.IdUsuario, c => c.MapFrom(x => x.Usuario!.Id))
               .ForMember(c => c.Usuario, c => c.MapFrom(x => x.Usuario!.Nome));



            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
            #endregion

        }
    }
}
