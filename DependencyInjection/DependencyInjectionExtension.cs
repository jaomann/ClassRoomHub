using Microsoft.Extensions.DependencyInjection;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Services;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Data.Repositories;

namespace DependencyInjection
{
    public static class DependencyInjectionExtension
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserService>();
            services.AddScoped<IStudentServices, StudentService>();
            services.AddScoped<ITeacherServices, TeacherService>();
            services.AddScoped<IScoreServices, ScoreService>();
            services.AddScoped<IModuleServices, ModuleService>();
            services.AddScoped<IGradeServices, GradeService>();
            services.AddScoped<IDeliveryServices, DeliveryService>();
            services.AddScoped<ICourseServices, CourseService>();
        }
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IDeliveryRepository, DeliveryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
