using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    internal class Activity
    {
        public string Title { get;set; }
        public string Description { get;set; }
        public DateTime DueDate { get;set; }
        public int ScorèPoints { get; set; }

        #region NavProperties
        public Guid ModuleGuid { get;set; }
        public Module Module { get;set; }
        public Guid TeacherGuid { get;set; }
        public Teacher Teacher { get;set;}
        #endregion
    }
}
