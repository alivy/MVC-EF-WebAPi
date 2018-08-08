using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_NationalUserOperation : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public string MyProvince{ get; set; }
        public string MyCity{ get; set; }
        public string MyAddress{ get; set; }
        public string MypointX{ get; set; }
        public string MypointY{ get; set; }
        public string HomeProvince{ get; set; }
        public string HomeCity{ get; set; }
        public string HomeAddress{ get; set; }
        public string HomepointX{ get; set; }
        public string HomepointY{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? VisitNumStutas{ get; set; }
    }
}
