using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ClassDictService : ServiceBase<Q_ClassDict>
    {
       
    }

    public class Q_ClassDict : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int ParentId{ get; set; }
        public int Depth{ get; set; }
        public string Path{ get; set; }
        public int OrderNo{ get; set; }
        public string Remark{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Status{ get; set; }
    }
}
