using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
    public class ClassService : BaseService<Class>, IClassServices
    {
        public ClassService(IClassRepository classRepository) : base(classRepository) { }
    }
}
