using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_InsuranceDelivery_bakService : ServiceBase<S_InsuranceDelivery_bak>
    {
       
    }

    public class S_InsuranceDelivery_bak : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public int? DeliveryType{ get; set; }
        public string Name{ get; set; }
        public string Phone{ get; set; }
        public string ProvinceCode{ get; set; }
        public string CityCode{ get; set; }
        public string AreaCode{ get; set; }
        public string Address{ get; set; }
        public string Zip{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
