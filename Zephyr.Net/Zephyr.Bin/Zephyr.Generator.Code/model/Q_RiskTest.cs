using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RiskTestService : ServiceBase<Q_RiskTest>
    {
       
    }

    public class Q_RiskTest : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int? Question1{ get; set; }
        public int? Question2{ get; set; }
        public int? Question3{ get; set; }
        public int? Question4{ get; set; }
        public int? Question5{ get; set; }
        public int? Question6{ get; set; }
        public int? Question7{ get; set; }
        public int? Question8{ get; set; }
        public int? Question9{ get; set; }
        public int? Question10{ get; set; }
        public int? Question11{ get; set; }
        public int? Question12{ get; set; }
        public int? Question13{ get; set; }
        public int? Question14{ get; set; }
        public int? Question15{ get; set; }
        public string Ask1{ get; set; }
        public string Ask2{ get; set; }
        public string Ask3{ get; set; }
        public string Ask4{ get; set; }
        public string Ask5{ get; set; }
        public string Ask6{ get; set; }
        public string Ask7{ get; set; }
        public string Ask8{ get; set; }
        public string Ask9{ get; set; }
        public string Ask10{ get; set; }
        public string Ask11{ get; set; }
        public string Ask12{ get; set; }
        public string Ask13{ get; set; }
        public string Ask14{ get; set; }
        public string Ask15{ get; set; }
        public int? GetScore{ get; set; }
        public int? RiskLevel{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
