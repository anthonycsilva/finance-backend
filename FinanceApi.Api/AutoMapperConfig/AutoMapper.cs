using AutoMapper;
using FinanceApi.Business.Entities;
using FinanceApi.Business.ViewModels.Request;
using FinanceApi.Business.ViewModels.Response;

namespace FinanceApi.Api.AutoMapperConfig
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UsuarioRequest, Usuario>();
            CreateMap<Usuario, UsuarioResponse>();
        }
    }
}