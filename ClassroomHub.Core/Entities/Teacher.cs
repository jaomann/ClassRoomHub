using ClassroomHub.Core.Enums;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    internal class Teacher
    {
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public Guid UserGuid { get; }
        public User user { get; }
        public Guid ModuleId { get; }
        List<Module> Modules { get; }
    }
}
