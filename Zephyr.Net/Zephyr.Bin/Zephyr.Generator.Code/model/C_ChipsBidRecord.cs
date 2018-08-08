using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsBidRecordService : ServiceBase<C_ChipsBidRecord>
    {
       
    }

    public class C_ChipsBidRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int uid{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public string ContractNumber{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal InvestNum{ get; set; }
        public int InvestShare{ get; set; }
        public int InvestType{ get; set; }
        public int InvestState{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
