using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Layers.DAL.EF.Modelos;
using ent = Layers.DO.Objects;

namespace Layers.Maps
{
    public class Maps
    {
        public static void createMaps() {

            try
            {
                Mapper.Initialize(cfg =>

                {

                    cfg.CreateMap<ent.WorkOrder, data.WorkOrder>();

                    //cfg.CreateMap<ent.Objects.Products, dato.Products>();

                    //cfg.CreateMap<ent.Objects.Suppliers, dato.Suppliers>();



                    cfg.CreateMap<data.WorkOrder, ent.WorkOrder>();

                    //cfg.CreateMap<dato.Products, ent.Objects.Products>();

                    //cfg.CreateMap<dato.Suppliers, ent.Objects.Suppliers>();



                });
            }
            catch (Exception)
            {

            }
            
        }
    }
}
