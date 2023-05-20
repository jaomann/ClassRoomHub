using System;

namespace ClassRoomHub.Web.ViewModels
{
    public class ActivitytoStudentViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string ModuleName { get; set; }
        public string TeacherName { get; set; }
        public int ScorePoints { get; set; }

    }
}
