using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_SafeCardFileService : ServiceBase<L_SafeCardFile>
    {
       
    }

    public class L_SafeCardFile : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string CardFace{ get; set; }
        public string CardBack{ get; set; }
        public string HandCard{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? AuthTime{ get; set; }
        public int? State{ get; set; }
    }
}
