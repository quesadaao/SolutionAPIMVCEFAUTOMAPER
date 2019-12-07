using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Layers.DAL.EF.Modelos;
using ent = Layers.DO.Objects;
using dal = Layers.DAL;
using Layers.DO.Interfaces;
using AutoMapper;

namespace Layers.BS
{
    public class WorkOrder : ICRUD<ent.WorkOrder>
    {
        public void Delete(ent.WorkOrder t)
        {
            var _ent = Mapper.Map<ent.WorkOrder, data.WorkOrder>(t);
            new dal.WorkOrder().Delete(_ent);
        }
        
        public void Insert(ent.WorkOrder t)
        {
            var _ent = Mapper.Map<ent.WorkOrder, data.WorkOrder>(t);
            new dal.WorkOrder().Insert(_ent);
        }

        public void Update(ent.WorkOrder t)
        {
            var _ent = Mapper.Map<ent.WorkOrder, data.WorkOrder>(t);
            new dal.WorkOrder().Update(_ent);
        }

        public IEnumerable<ent.WorkOrder> GetAll()
        {
            var DetailsQuery = new dal.WorkOrder().GetAll();
            var res = Mapper.Map<IEnumerable<data.WorkOrder>, IEnumerable<ent.WorkOrder>>(DetailsQuery);
            return res;
        }

        public ent.WorkOrder GetOneById(int id)
        {
            var DetailsQuery = new dal.WorkOrder().GetOneById(id);
            var res = Mapper.Map<data.WorkOrder, ent.WorkOrder>(DetailsQuery);   
            return res;
        }
    }
}
