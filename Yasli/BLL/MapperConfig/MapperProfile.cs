using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Entities;

namespace BLL.MapperConfig
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ChildrenDTO, Child>()
                  .ForMember(a => a.Name, src => src.MapFrom(a => a.Name))
                  .ForMember(a => a.Age, src => src.MapFrom(a => a.Age))
                  .ReverseMap()
                  .ForPath(a => a.Name, otp => otp.MapFrom(src => src.Name))
                  .ForPath(a => a.Age, otp => otp.MapFrom(src => src.Age));

            CreateMap<ParentDTO, Parent>()
                  .ForMember(a => a.Name, src => src.MapFrom(a => a.Name))
                  .ForMember(a => a.PhoneNumber, src => src.MapFrom(a => a.PhoneNumber))
                  .ForMember(a => a.TypofParent, src => src.MapFrom(a => a.TypeOfParent))
                  .ReverseMap()
                  .ForPath(a => a.Name, otp => otp.MapFrom(src => src.Name))
                  .ForPath(a => a.PhoneNumber, otp => otp.MapFrom(src => src.PhoneNumber))
                  .ForPath(a => a.TypeOfParent, otp => otp.MapFrom(src => src.TypofParent));

            CreateMap<GroupDTO, Group>()
                  .ForMember(a => a.Name, src => src.MapFrom(a => a.Name))
                  .ForMember(a => a.Number, src => src.MapFrom(a => a.Number))
                  .ForMember(a => a.Childrens, src => src.MapFrom(a => a.Childrens))
                  .ReverseMap()
                  .ForPath(a => a.Name, otp => otp.MapFrom(src => src.Name))
                  .ForPath(a => a.Number, otp => otp.MapFrom(src => src.Number))
                  .ForPath(a => a.Childrens, otp => otp.MapFrom(src => src.Childrens));

        }

    }
}
