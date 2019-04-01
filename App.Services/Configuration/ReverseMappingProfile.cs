using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DataAccess.DbModels;
using App.Models.Models;
using AutoMapper;

namespace App.Services.Configuration
{
   public class ReverseMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<UserModel, User>().ReverseMap();
        }
       
    }
}
