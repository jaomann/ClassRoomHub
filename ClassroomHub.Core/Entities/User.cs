using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassroomHub.Core.Entities
{
    internal class User
    {
        private Guid Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get { return "Você não pode ter acesso."; } set {; } }
    }
}
