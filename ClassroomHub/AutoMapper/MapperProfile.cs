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

            CreateMap<Student, StudentViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email));
            CreateMap<StudentViewModel, Student>();
            
            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email));
            CreateMap<TeacherViewModel, Teacher>();
            CreateMap<ActivityViewModel, Activity>().ReverseMap();
            CreateMap<ActivityCompair, ActivityCompairVM>().ReverseMap();
            CreateMap<ModuleViewModel, Module>().ReverseMap();
            CreateMap<Delivery, DeliveryViewModel>().ReverseMap();
            CreateMap<ActivityViewModel, DeliveryViewModel>().
                ForMember(x => x.DueDate, src => src.MapFrom(x => x.DueDate))
               .ForMember(x => x.ActivityId, src => src.MapFrom(x => x.Id))
               .ForMember(x => x.ModuleName, src => src.MapFrom(x => x.Module.Name))
               .ForMember(x => x.Description, src => src.MapFrom(x => x.Description))
               .ForMember(x => x.Score, src => src.MapFrom(x => x.Score));
               
            
        }
    }
}