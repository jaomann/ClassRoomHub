using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ModuleId { get; set; }
        public List<Module> Modules { get; set; }
    }
}
