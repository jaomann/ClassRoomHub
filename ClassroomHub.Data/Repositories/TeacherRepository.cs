﻿using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(Context context) : base(context)
        {
        }

        public IEnumerable<Teacher> GetFullTeacher()
        {
            return this.Get().Include(x => x.User);
        }
    }
}
