using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsAttornRecord : IAggregateRoot
    {

        [Identity]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string ChipsNumber{ get; set; }
        public int ChipsId{ get; set; }
        public int ChipsBidId{ get; set; }
        public int InvestNum{ get; set; }
        public decimal TransferNum{ get; set; }
        public int SurplusPeriods{ get; set; }
        public string AuditOpinion{ get; set; }
        public int AuditUid{ get; set; }
        public DateTime AuditTime{ get; set; }
        public DateTime ApplyTime{ get; set; }
        public DateTime? FullTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public int State{ get; set; }
    }
}
