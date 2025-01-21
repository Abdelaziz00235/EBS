using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {

        public int TCount()
        {
            return _repository.Count();
        }

        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public int TFilteredCount(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _repository.FilteredCount(predicate);
        }

        public T TGetByFilter(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public T TGetById(int id)
        {
           return _repository.GetById(id);
        }

        public List<T> TGetFilteredList(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
           return _repository.GetFilteredList(predicate);
        }

        public List<T> TGetList()
        {
           return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
           _repository.Update(entity);
        }
    }
}
