using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SubjectPayService : ServiceBase<Q_SubjectPay>
    {
       
    }

    public class Q_SubjectPay : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string LoanNumber{ get; set; }
        public int Uid{ get; set; }
        public string UserName{ get; set; }
        public string FullName{ get; set; }
        public int? ProjectID{ get; set; }
        public string ContractNumber{ get; set; }
        public int? Type{ get; set; }
        public string SubjectTitle{ get; set; }
        public decimal? AmountMax{ get; set; }
        public decimal? AmountMin{ get; set; }
        public int? Periods{ get; set; }
        public string PassWord{ get; set; }
        public decimal? Amount{ get; set; }
        public int Day{ get; set; }
        public decimal? LV{ get; set; }
        public decimal? RewardLV{ get; set; }
        public int? RaisingPeriod{ get; set; }
        public int? RepaymentType{ get; set; }
        public string Safes{ get; set; }
        public string SubjectType{ get; set; }
        public string Description{ get; set; }
        public string AuditOpinion{ get; set; }
        public int? AuditUid{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public DateTime? ApplyTime{ get; set; }
        public int? PublishUid{ get; set; }
        public DateTime? PublishTime{ get; set; }
        public DateTime? ReleaseTime{ get; set; }
        public int? FullUid{ get; set; }
        public DateTime? FullTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public int State{ get; set; }
        public int? IsBankAccount{ get; set; }
        public decimal? Payment{ get; set; }
        public decimal? RePayment{ get; set; }
        public int? PaymentState{ get; set; }
        public int WarrantUid{ get; set; }
    }
}
