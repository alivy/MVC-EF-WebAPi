using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsPicService : ServiceBase<C_ChipsPic>
    {
       
    }

    public class C_ChipsPic : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public string PicUrl{ get; set; }
        public string Title{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
