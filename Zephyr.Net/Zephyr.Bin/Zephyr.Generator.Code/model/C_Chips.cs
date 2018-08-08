using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_Chips : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ChipsNumber{ get; set; }
        public int Uid{ get; set; }
        public string UserName{ get; set; }
        public string FullName{ get; set; }
        public int ProjectID{ get; set; }
        public int ChipsType{ get; set; }
        public string Title{ get; set; }
        public string ContractNumber{ get; set; }
        public string ListPic{ get; set; }
        public decimal LV{ get; set; }
        public int MinShare{ get; set; }
        public int MaxShare{ get; set; }
        public int TotalShare{ get; set; }
        public decimal Investment{ get; set; }
        public decimal Amount{ get; set; }
        public int ChipsCycle{ get; set; }
        public int PeriodsMonth{ get; set; }
        public int RaisingPeriod{ get; set; }
        public int Periods{ get; set; }
        public int ChipsShen{ get; set; }
        public int ChipsShi{ get; set; }
        public int ChipsQu{ get; set; }
        public string Addree{ get; set; }
        public decimal Acreage{ get; set; }
        public decimal RenovationCost{ get; set; }
        public decimal InRent{ get; set; }
        public DateTime? InRentStarDate{ get; set; }
        public DateTime? InRentEndDate{ get; set; }
        public decimal Poundage{ get; set; }
        public decimal PropertyFee{ get; set; }
        public decimal OperatingCosts{ get; set; }
        public decimal ProjectInCome{ get; set; }
        public int SpaceTypeId{ get; set; }
        public string Desc{ get; set; }
        public string VideoUrl{ get; set; }
        public string ReCode{ get; set; }
        public DateTime? OperateStarDate{ get; set; }
        public string RiskControl{ get; set; }
        public string AuditOpinion{ get; set; }
        public int? AuditUid{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public DateTime? ApplyTime{ get; set; }
        public int? PublishUid{ get; set; }
        public DateTime? PublishTime{ get; set; }
        public DateTime? ReleaseTime{ get; set; }
        public int? FullUid{ get; set; }
        public DateTime? FullTime{ get; set; }
        public int ClearTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public int State{ get; set; }
        public decimal LeadMoney{ get; set; }
        public decimal PlatformBonus{ get; set; }
    }
}
