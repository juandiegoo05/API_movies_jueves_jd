using API_movies_jueves_jd.DAL.Models;
using API_movies_jueves_jd.DAL.Models.Dtos;
using AutoMapper;

namespace API_movies_jueves_jd.MoviesMapper
{
    public class Mappers : Profile 
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
