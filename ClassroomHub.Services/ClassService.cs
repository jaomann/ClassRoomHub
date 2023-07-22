using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClassroomHub.Core.ApplicationExeception;

namespace ClassroomHub.Services
{
    public class ClassService : BaseService<Class>, IClassServices
    {
        public ClassService(IClassRepository classRepository) : base(classRepository) { }
        public override void Create(Class entity)
        {
            
            try
            {
                ValidatePeriod(entity);
            }
            catch (InvalidDateException e)
            {
                throw e;
            }
                base.Create(entity);
        }

        public void ValidatePeriod(Class entity)
        {
            if(entity.End < entity.Start)
            {
               throw new InvalidDateException("A data de termino não deve ser menor que a de inicio");
            }
        }
    }
}
