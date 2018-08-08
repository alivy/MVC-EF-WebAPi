using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreLineFree : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string Title{ get; set; }
        public DateTime BeginTime{ get; set; }
        public DateTime EndTime{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? CreditCardId{ get; set; }
        public string OrderNum{ get; set; }
        public decimal? MoneyNum{ get; set; }
        public DateTime? UsedTime{ get; set; }
    }
}
