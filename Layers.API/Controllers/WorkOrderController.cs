using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Layers.BS;
using ent = Layers.DO.Objects;
using map = Layers.Maps.Maps;

namespace Layers.API.Controllers
{
    [Route("api/WorkOrder")] // Simboliza el direccionamiento correcto para que el url funcione
    public class WorkOrderController : ApiController
    {

        public WorkOrderController() {
            map.createMaps();
        }

        [Route("api/WorkOrder/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.WorkOrder> GetAll()
        {
            // https://localhost:44347/api/WorkOrder/GetAll
            return new Layers.BS.WorkOrder().GetAll();
        }

        [Route("api/WorkOrder/GetOneById/5")]
        [HttpGet]
        public ent.WorkOrder GetOneById(int id)
        {
            return new Layers.BS.WorkOrder().GetOneById(id);
        }

        [Route("api/WorkOrder/Delete")]
        [HttpPost]
        public void Delete(ent.WorkOrder t)
        {
            new Layers.BS.WorkOrder().Delete(t);
        }

        [Route("api/WorkOrder/Insert")]
        [HttpPost]
        public void Insert(ent.WorkOrder t)
        {
            new Layers.BS.WorkOrder().Insert(t);
        }

        [Route("api/WorkOrder/Update")]
        [HttpPost]
        public void Update(ent.WorkOrder t)
        {
            new Layers.BS.WorkOrder().Update(t);
        }
    }
}
