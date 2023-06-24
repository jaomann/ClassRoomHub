using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IUserServices : IBaseServices<User>
    {
        bool Verify(User entity);
    }
}
