using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class sysdiagramsService : ServiceBase<sysdiagrams>
    {
       
    }

    public class sysdiagrams : ModelBase
    {

        public string name{ get; set; }
        public int principal_id{ get; set; }
        [Identity]
        [PrimaryKey]
        public int diagram_id{ get; set; }
        public int? version{ get; set; }
        public byte[] definition{ get; set; }
    }
}
