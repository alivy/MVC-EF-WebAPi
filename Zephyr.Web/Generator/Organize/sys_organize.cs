using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    [Module("Sys")]
    public class sys_organizeService : ServiceBase<sys_organize>
    {
       
    }

    public class sys_organize : ModelBase
    {
        [PrimaryKey]   
        public string OrganizeCode { get; set; }
        public string ParentCode { get; set; }
        public string OrganizeSeq { get; set; }
        public string OrganizeName { get; set; }
        public string Description { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
