using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Services
{
    public class DeliveryService : BaseService<Delivery>, IDeliveryServices
    {
        public DeliveryService(IDeliveryRepository baseRepository) : base(baseRepository)
        {
        }

        public IEnumerable<Delivery> GetAllCorrect()
        {
            return this.GetAll().Where(x => x.Score != 0);
        }

        public IEnumerable<Delivery> GetAllDone()
        {
            return this.GetAll().Where(x => x.Solution != null);
        }
    }
}
