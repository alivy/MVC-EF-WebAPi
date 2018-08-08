using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_WPFundRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? UserID{ get; set; }
        public string UserName{ get; set; }
        public decimal? UsableSum{ get; set; }
        public decimal? HandleSum{ get; set; }
        public decimal? FreezeSum{ get; set; }
        public decimal? InCome{ get; set; }
        public decimal? Spending{ get; set; }
        public decimal? DueinSum{ get; set; }
        public string OrderNumber{ get; set; }
        public int? OperateType{ get; set; }
        public string PayNumber{ get; set; }
        public string PayBank{ get; set; }
        public decimal? Cost{ get; set; }
        public decimal? CurrentLV{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string OperateUser{ get; set; }
        public string Remarks{ get; set; }
        public int? WPid{ get; set; }
    }
}
