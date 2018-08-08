using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Advert : IAggregateRoot
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public DateTime? BeginDate{ get; set; }
        public DateTime? EndDate{ get; set; }
        public string Url{ get; set; }
        public int? ClickNum{ get; set; }
        public int? UserID{ get; set; }
        public string UserName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int AdvertClassId{ get; set; }
        public string Remark{ get; set; }
        public string PicPath{ get; set; }
    }
}
