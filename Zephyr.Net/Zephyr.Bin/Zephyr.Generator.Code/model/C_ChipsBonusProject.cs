using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsBonusProjectService : ServiceBase<C_ChipsBonusProject>
    {
       
    }

    public class C_ChipsBonusProject : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int BonusUid{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public int BonusPeriods{ get; set; }
        public DateTime BonusTime{ get; set; }
        public DateTime? ActualBonusTime{ get; set; }
        public decimal BonusTotalNum{ get; set; }
        public decimal BonusFee{ get; set; }
        public decimal BonusNum{ get; set; }
        public decimal ActualBonusNum{ get; set; }
        public int OverdueDay{ get; set; }
        public decimal OverDuePenalty{ get; set; }
        public string ContractNumber{ get; set; }
        public string BonusNumber{ get; set; }
        public int TypeId{ get; set; }
        public int BonusState{ get; set; }
    }
}
