using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class F_TemplateManageService : ServiceBase<F_TemplateManage>
    {
       
    }

    public class F_TemplateManage : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TemplateName{ get; set; }
        public string TemplateNo{ get; set; }
        public string TemplateUrl{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
