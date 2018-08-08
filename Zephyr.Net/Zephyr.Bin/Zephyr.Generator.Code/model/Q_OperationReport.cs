using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_OperationReport : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public int RegisterNum{ get; set; }
        public int TotalRegisterNum{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal TotalInvestNum{ get; set; }
        public decimal Earning{ get; set; }
        public decimal TotalEarning{ get; set; }
        public decimal PrevInvest{ get; set; }
        public int PrevNum{ get; set; }
        public decimal LastInvest{ get; set; }
        public int LastNum{ get; set; }
        public int CarCount{ get; set; }
        public int HouseCount{ get; set; }
        public int ExperienceCount{ get; set; }
        public decimal CarAmount{ get; set; }
        public decimal HouseAmount{ get; set; }
        public decimal ExperienceAmount{ get; set; }
        public decimal OneAmount{ get; set; }
        public decimal ThreeAmount{ get; set; }
        public decimal SixAmount{ get; set; }
        public string OneRate{ get; set; }
        public string ThreeRate{ get; set; }
        public string SixRate{ get; set; }
        public string ExperienceRate{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime StartTime{ get; set; }
        public DateTime EndTime{ get; set; }
        public decimal? WelfareAmount{ get; set; }
        public decimal? WelfareRate{ get; set; }
        public int? ProjectCount{ get; set; }
        public decimal? ProjectAmount{ get; set; }
        public int? QiRongTongCount{ get; set; }
        public decimal? QiRongTongAmount{ get; set; }
        public decimal CarRate{ get; set; }
        public decimal HouseRate{ get; set; }
        public decimal ProjectRate{ get; set; }
        public decimal QiRongTongRate{ get; set; }
        public decimal DecemberRate{ get; set; }
        public decimal DecemberAmount{ get; set; }
        public decimal YueOneAmount{ get; set; }
        public decimal YueThreeAmount{ get; set; }
        public decimal YueSixAmount{ get; set; }
        public decimal YueDecemberAmount{ get; set; }
        public decimal YueOneRate{ get; set; }
        public decimal YueThreeRate{ get; set; }
        public decimal YueSixRate{ get; set; }
        public decimal YueDecemberRate{ get; set; }
        public int LoanNum{ get; set; }
        public decimal LoanAmount{ get; set; }
        public decimal LoanRate{ get; set; }
    }
}
