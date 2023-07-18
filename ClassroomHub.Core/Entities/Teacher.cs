
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Teacher : EntityBase
    {
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public Guid UserId { get; }
        public User User { get; }
        public Guid ModuleId { get; }
        public List<Module> Module { get; }

    }
}
