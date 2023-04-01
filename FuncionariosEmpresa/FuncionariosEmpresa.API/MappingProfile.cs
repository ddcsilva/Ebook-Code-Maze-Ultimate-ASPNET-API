using AutoMapper;
using FuncionariosEmpresa.Entities.Models;
using FuncionariosEmpresa.Shared.DataTransferObjects;

namespace FuncionariosEmpresa.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Empresa, EmpresaDto>()
                .ForCtorParam("EnderecoCompleto", option => 
                    option.MapFrom(x => string.Join(' ', x.Endereco, x.Pais)));
        }
    }
}
