using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        private readonly Context _context;
        public ActivityRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
