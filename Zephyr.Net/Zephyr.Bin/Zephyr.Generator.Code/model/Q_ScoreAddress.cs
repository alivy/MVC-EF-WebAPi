using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreAddressService : ServiceBase<Q_ScoreAddress>
    {
       
    }

    public class Q_ScoreAddress : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int UserId{ get; set; }
        public string TrueName{ get; set; }
        public int ProvinceId{ get; set; }
        public string ProvinceName{ get; set; }
        public int CityId{ get; set; }
        public string CityName{ get; set; }
        public int? AreaId{ get; set; }
        public string AreaName{ get; set; }
        public string Address{ get; set; }
        public string PhoneNum{ get; set; }
        public int IsDefaultAddr{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
