using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SecurityRepay : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? WarrantUid{ get; set; }
        public int? RePayUid{ get; set; }
        public decimal? RepayAmount{ get; set; }
        public string OrderNum{ get; set; }
        public int? SubjectBidId{ get; set; }
        public int? SubjectPayId{ get; set; }
        public decimal? Warrant_Fee{ get; set; }
        public decimal? Fine_Fee{ get; set; }
        public decimal? Absolution_Fee{ get; set; }
        public decimal? Fee{ get; set; }
        public int State{ get; set; }
        public string Out_serial_no{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdaTime{ get; set; }
        public string RepayNumber{ get; set; }
        public int? Periods{ get; set; }
    }
}
