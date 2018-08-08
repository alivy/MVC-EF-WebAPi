using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_WarningService : ServiceBase<Q_Warning>
    {
       
    }

    public class Q_Warning : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Email{ get; set; }
        public int? EState{ get; set; }
        public string Phone{ get; set; }
        public int PState{ get; set; }
        public string UserName{ get; set; }
        public decimal? Amount{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
