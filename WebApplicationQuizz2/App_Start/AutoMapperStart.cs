using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationQuizz2
{
    public class AutoMapperStart
    {
        public static void Initialize()
        {
            Mapper.Initialize(
             cfg => {
                 cfg.CreateMap<User, Users>().ReverseMap();
             });
        }
    }
}