using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_AddressService : ServiceBase<L_Address>
    {
       
    }

    public class L_Address : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int ProvinceId{ get; set; }
        public int CityId{ get; set; }
        public int RegionId{ get; set; }
        public string DetailAddress{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
