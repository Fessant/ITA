using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using AutoMapper;
using DbEntity;
using RegistrationExample.Models;


namespace RegistrationExample.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<UserProfile>();
            });
        }
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Role, source => source.MapFrom(x => x.Role.Name));

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.RoleId, source => source.MapFrom(x => x.Role.Id));
        } 
    }