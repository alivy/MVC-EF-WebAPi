using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_AssetsSubJectBidRecordService : ServiceBase<P_AssetsSubJectBidRecord>
    {
       
    }

    public class P_AssetsSubJectBidRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public int? SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public string ContractNumber{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal? InvestNum{ get; set; }
        public int? InvestType{ get; set; }
        public int? InvestState{ get; set; }
        public int? RedId{ get; set; }
        public int LvBondId{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
