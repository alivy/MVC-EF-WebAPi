using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class W_CapitalRecordService : ServiceBase<W_CapitalRecord>
    {
       
    }

    public class W_CapitalRecord : ModelBase
    {

        [PrimaryKey]
        public int id{ get; set; }
        public int WId{ get; set; }
        public string UserName{ get; set; }
        public string FullName{ get; set; }
        public int UserId{ get; set; }
        public decimal TotalNum{ get; set; }
        public decimal EnableNum{ get; set; }
        public decimal DiffNum{ get; set; }
        public DateTime LastTime{ get; set; }
        public int LastId{ get; set; }
        public int TypeId{ get; set; }
        public string Remark{ get; set; }
        public int State{ get; set; }
    }
}
