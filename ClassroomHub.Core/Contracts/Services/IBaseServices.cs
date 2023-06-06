using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IBaseServices<T> where T : EntityBase
    {
        void Create(T entity);
        T GetById(Guid id);
    }
}
