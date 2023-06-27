using AutoMapper;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;

namespace ClassroomHub.Web.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserViewModel, User>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.Email))
                .ForMember(x => x.Birthday, src => src.MapFrom(x =>x.Birthday))
                .ForMember(x => x.Password, src => src.MapFrom(x => x.Password))
                .ReverseMap();

            CreateMap<CourseViewModel, Course>().ReverseMap();
            CreateMap<ClassViewModel, Class>().ReverseMap();
        }
    }
}