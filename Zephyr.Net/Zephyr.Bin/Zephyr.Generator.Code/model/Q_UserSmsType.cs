using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserSmsTypeService : ServiceBase<Q_UserSmsType>
    {
       
    }

    public class Q_UserSmsType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public string Remark{ get; set; }
        public int? SortNum{ get; set; }
        public int IsDel{ get; set; }
    }
}
