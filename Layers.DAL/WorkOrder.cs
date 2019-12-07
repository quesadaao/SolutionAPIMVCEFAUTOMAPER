using Layers.DAL.EF.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using data = Layers.DAL.EF.Modelos;

namespace Layers.DAL
{
    public class WorkOrder
    {
        private Repository.Repository<data.WorkOrder> _repository = new Repository.Repository<data.WorkOrder>(new TuneUpEntities());

        public void Insert(data.WorkOrder entidad)
        {
            try
            {
                _repository.Insert(entidad);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw ee;
            }
            
        }

        public void Delete(data.WorkOrder entidad)
        {
            try
            {
                _repository.Delete(entidad);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw ee;
            }

        }

        public void Update(data.WorkOrder entidad)
        {
            try
            {
                _repository.Update(entidad);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw ee;
            }

        }

        public IEnumerable<data.WorkOrder> GetAll()
        {
            try
            {
                return _repository.GetAll().ToList();
            }
            catch (Exception ee)
            {

                throw ee;
            }
        }

        public data.WorkOrder GetOneById(int id)
        {
            try
            {
                return _repository.GetOneById(id);
            }
            catch (Exception ee)
            {

                throw ee;
            }
        }

        public data.WorkOrder GetOne(Expression<Func<data.WorkOrder, bool>> predicado)
        {
            try
            {
                return _repository.GetOne(predicado);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }
}
