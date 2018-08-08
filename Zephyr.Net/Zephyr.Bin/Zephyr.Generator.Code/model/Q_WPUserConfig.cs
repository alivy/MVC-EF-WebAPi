using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_WPUserConfigService : ServiceBase<Q_WPUserConfig>
    {
       
    }

    public class Q_WPUserConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? UserId{ get; set; }
        public string UserName{ get; set; }
        public int? MoneyChange{ get; set; }
        public int? MoenyHide{ get; set; }
        public DateTime? RegularInComeDateTime{ get; set; }
        public decimal? RegularInComeNum{ get; set; }
        public string RegularInComeRemark{ get; set; }
        public int? RegularOnComeDateTime{ get; set; }
        public decimal? RegularOnComeNum{ get; set; }
        public string RegularOnComeRemark{ get; set; }
        public int? OperateUser{ get; set; }
        public DateTime? OperateDateTime{ get; set; }
        public int? Status{ get; set; }
    }
}
