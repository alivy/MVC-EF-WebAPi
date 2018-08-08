using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsBonus : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public int ChipsBidId{ get; set; }
        public int BonusPeriods{ get; set; }
        public DateTime? BonusTime{ get; set; }
        public DateTime? ActualBonusTime{ get; set; }
        public decimal Profit{ get; set; }
        public decimal InterestMgtFee{ get; set; }
        public int IsOverdue{ get; set; }
        public int OverdueDay{ get; set; }
        public decimal OverDuePenalty{ get; set; }
        public string BonusNumber{ get; set; }
        public int TypeId{ get; set; }
        public int BonusUid{ get; set; }
        public int BonusState{ get; set; }
    }
}
