using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAd.API.Models;

namespace WebAd.API.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            //This will map attribute names (as long as theyre the same)
            CreateMap<AdvertModel, AdvertDbModel>();
        }
    }
}
