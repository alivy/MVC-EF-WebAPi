using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_LinksService : ServiceBase<Q_Links>
    {
       
    }

    public class Q_Links : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Url{ get; set; }
        public int Type{ get; set; }
        public string Pic{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public int? Class{ get; set; }
    }
}
