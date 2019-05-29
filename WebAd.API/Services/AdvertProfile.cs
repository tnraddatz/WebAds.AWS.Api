using AdvertApi.Models;
using AutoMapper;

namespace WebAd.API.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertDbModel, AdvertModel>().ReverseMap();
        }
    }
}
