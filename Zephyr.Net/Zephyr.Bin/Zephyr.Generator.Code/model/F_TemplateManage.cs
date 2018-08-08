using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class F_TemplateManage : IAggregateRoot
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
