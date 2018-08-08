using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_WPDayProfit : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? Profit{ get; set; }
        public decimal? In{ get; set; }
        public decimal? Out{ get; set; }
        public string Remark{ get; set; }
        public DateTime? StatisticalDay{ get; set; }
        public string Operator{ get; set; }
    }
}
