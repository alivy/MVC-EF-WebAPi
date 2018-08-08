using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceOrder_bak : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public string OrderNumber{ get; set; }
        public string TaskId{ get; set; }
        public string CityCode{ get; set; }
        public string QuotePrvId{ get; set; }
        public decimal? PayAmount{ get; set; }
        public int? State{ get; set; }
        public int BackState{ get; set; }
        public decimal CiBackTotal{ get; set; }
        public decimal CiBackLv{ get; set; }
        public decimal CiUserBackLv{ get; set; }
        public decimal CiBackResult{ get; set; }
        public decimal CiUserBackResult{ get; set; }
        public decimal BiBackTotal{ get; set; }
        public decimal BiBackLv{ get; set; }
        public decimal BiUserBackLv{ get; set; }
        public decimal BiBackResult{ get; set; }
        public decimal BiUserBackResult{ get; set; }
        public decimal BackTotal{ get; set; }
        public decimal UserBackTotal{ get; set; }
        public DateTime AddTime{ get; set; }
        public string ApplicantPhone{ get; set; }
        public int? ApplicantBackState{ get; set; }
        public int? ApplicantRedBag{ get; set; }
        public string ApplicantRedBagDesc{ get; set; }
        public string RecommenderPhone{ get; set; }
        public int? RecommenderBackState{ get; set; }
        public int? RecommenderRedBag{ get; set; }
        public string RecommenderRedBagDesc{ get; set; }
        public int? ApplicantAddRedBag{ get; set; }
    }
}
