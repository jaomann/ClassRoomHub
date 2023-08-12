using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
    public class ModuleService : BaseService<Module>, IModuleServices
    {
        public ModuleService(IModuleRepository baseRepository) : base(baseRepository)
        {
        }
    }
}
