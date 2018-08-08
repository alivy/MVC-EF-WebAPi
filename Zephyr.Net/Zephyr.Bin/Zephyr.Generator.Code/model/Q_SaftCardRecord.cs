using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SaftCardRecordService : ServiceBase<Q_SaftCardRecord>
    {
       
    }

    public class Q_SaftCardRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string FullName{ get; set; }
        public string CardNum{ get; set; }
        public string Birthday{ get; set; }
        public int Sex{ get; set; }
        public string MerchantOrder{ get; set; }
        public string ResultNo{ get; set; }
        public string ResultDesc{ get; set; }
        public string OrderNumer{ get; set; }
        public decimal? Cost{ get; set; }
        public int State{ get; set; }
    }
}
