using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class F_ContractFilingService : ServiceBase<F_ContractFiling>
    {
       
    }

    public class F_ContractFiling : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ContractNo{ get; set; }
        public string Msg{ get; set; }
        public DateTime Addtime{ get; set; }
        public int State{ get; set; }
    }
}
