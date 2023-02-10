using AutoMapper;
using FilmesAPI6.Data.Dtos;
using FilmesAPI6.Models;

namespace FilmesAPI6.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
