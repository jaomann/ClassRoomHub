using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IDeliveryServices : IBaseServices<Delivery>
    {
        IEnumerable<Delivery> GetAllDone();
        IEnumerable<Delivery> GetAllCorrect();
    }
}
