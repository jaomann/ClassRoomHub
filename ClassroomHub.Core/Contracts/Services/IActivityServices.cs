using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IActivityServices : IBaseServices<Activity>
    {
        Guid Compare(ActivityCompair entity);
        IEnumerable<Activity> GetAllDone();
    }
}
