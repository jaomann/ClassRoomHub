
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Teacher : EntityBase
    {
        public string Name { get; set;  }
        public string Surname { get; set; }
        public string Specialization { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ModuleId { get; set; }
        public List<Module> Module { get; set; }

    }
}
