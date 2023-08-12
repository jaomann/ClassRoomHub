using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
    public class DeliveryService : BaseService<Delivery>, IDeliveryServices
    {
        public DeliveryService(IDeliveryRepository baseRepository) : base(baseRepository)
        {
        }
    }
}
