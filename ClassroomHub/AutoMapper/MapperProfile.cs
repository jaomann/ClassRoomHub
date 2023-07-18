using AutoMapper;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using System.Collections.Generic;

namespace ClassroomHub.Web.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();

            CreateMap<CourseViewModel, Course>().ReverseMap();
            CreateMap<ClassViewModel, Class>().ReverseMap();
            CreateMap<StudentViewModel, Student>().ReverseMap();
        }
    }
}