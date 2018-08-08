using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsAttronService : ServiceBase<C_ChipsAttron>
    {
       
    }

    public class C_ChipsAttron : ModelBase
    {

        [Identity]
        public int Id{ get; set; }
        public string AttronChipsNumber{ get; set; }
        public string ChipsNumber{ get; set; }
        public decimal FloatNum{ get; set; }
        public decimal FeeNum{ get; set; }
    }
}
