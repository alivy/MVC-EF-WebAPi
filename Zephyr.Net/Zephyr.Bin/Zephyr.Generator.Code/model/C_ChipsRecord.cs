using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsRecordService : ServiceBase<C_ChipsRecord>
    {
       
    }

    public class C_ChipsRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string CompanyName{ get; set; }
        public int Uid{ get; set; }
        public string ChipsNumber{ get; set; }
        public string Contact{ get; set; }
        public string Tel{ get; set; }
        public string Email{ get; set; }
        public string Desc{ get; set; }
        public int ChipsType{ get; set; }
        public decimal Amount{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public int ChipsCycle{ get; set; }
    }
}
