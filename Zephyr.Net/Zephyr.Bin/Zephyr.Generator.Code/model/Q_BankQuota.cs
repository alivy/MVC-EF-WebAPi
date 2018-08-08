using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BankQuota : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string BankName{ get; set; }
        public string BankCode{ get; set; }
        public string BankLogo{ get; set; }
        public string BankWeiXinLogo{ get; set; }
        public decimal? SingleNum{ get; set; }
        public decimal? SingleDay{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int State{ get; set; }
    }
}
