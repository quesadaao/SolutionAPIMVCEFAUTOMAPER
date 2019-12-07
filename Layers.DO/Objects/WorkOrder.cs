using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.DO.Objects
{
    public class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderQty { get; set; }
        public Nullable<int> StockedQty { get; set; }
        public short ScrappedQty { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<short> ScrapReasonID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
