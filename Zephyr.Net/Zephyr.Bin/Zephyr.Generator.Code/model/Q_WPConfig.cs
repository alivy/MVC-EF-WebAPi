using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_WPConfigService : ServiceBase<Q_WPConfig>
    {
       
    }

    public class Q_WPConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public decimal? CurrentLV{ get; set; }
        public int? Status{ get; set; }
        public int? PasswordStatus{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public decimal? AmountFirst{ get; set; }
        public decimal? AmountMax{ get; set; }
        public decimal? WPCount{ get; set; }
        public DateTime? AddDateTime{ get; set; }
        public DateTime? UpDateTime{ get; set; }
        public int? OperateUser{ get; set; }
    }
}
