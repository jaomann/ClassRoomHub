using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Services
{
    public class UserService : BaseService<User>, IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this._userRepository = userRepository;
        }
        public bool Verify(User user)
        {
            var real_User = _userRepository.GetByEmail(user.Email);
            if (real_User != null && user.Password.Equals(real_User.Password))
            {
                return true;
            }
            return false;
        }
    }
}