using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Services
{
    public class ActivityService : BaseService<Activity>, IActivityServices
    {
        private readonly IActivityRepository _activityRepository;
        public ActivityService(IActivityRepository baseRepository) : base(baseRepository)
        {
            _activityRepository = baseRepository;
        }

        public Guid Compare(ActivityCompair entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAllDone()
        {
            throw new NotImplementedException();
        }
    }
}
