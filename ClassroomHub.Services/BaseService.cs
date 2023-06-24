using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
    public class BaseService<T> : IBaseServices<T> where T : EntityBase
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Create(T entity)
        {
            _baseRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
           _baseRepository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }

    }
}
