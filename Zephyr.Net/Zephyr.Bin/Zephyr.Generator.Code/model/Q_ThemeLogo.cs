using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ThemeLogo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public string ImgUrl{ get; set; }
        public DateTime? StartTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? IsFestival{ get; set; }
        public int? OrderNum{ get; set; }
        public int? IsWork{ get; set; }
        public int? Type{ get; set; }
    }
}
