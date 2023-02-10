using AutoMapper;
using FilmesAPI6.Data.Dtos;
using FilmesAPI6.Models;

namespace FilmesAPI6.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
