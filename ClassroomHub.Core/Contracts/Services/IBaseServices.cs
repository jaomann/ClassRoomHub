using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IBaseServices<T> where T : EntityBase
    {
        void Create(User user);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        void Update(User user);
        void Delete(Guid id);
    }
}
