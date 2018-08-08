using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Banner : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string title{ get; set; }
        public int? bannerType{ get; set; }
        public int? bannerPosition{ get; set; }
        public string imgUrl{ get; set; }
        public string linkUrl{ get; set; }
        public int? isActivity{ get; set; }
        public int? orderNum{ get; set; }
        public int? isWork{ get; set; }
        public DateTime? workStartTime{ get; set; }
        public DateTime? workEndTime{ get; set; }
        public DateTime? addTime{ get; set; }
        public string activityImgUrl{ get; set; }
        public string homeImgUrl{ get; set; }
    }
}
