using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeOrderDetail_bakService : ServiceBase<Q_SafeOrderDetail_bak>
    {
       
    }

    public class Q_SafeOrderDetail_bak : ModelBase
    {

        public int? id{ get; set; }
        public string orderId{ get; set; }
        public int? userId{ get; set; }
        public string merchantOrderId{ get; set; }
        public string status{ get; set; }
        public string remark{ get; set; }
        public string licenseFlag{ get; set; }
        public string isRenewal{ get; set; }
        public DateTime? startDateBI{ get; set; }
        public DateTime? endDateBI{ get; set; }
        public DateTime? startDateCI{ get; set; }
        public DateTime? endDateCI{ get; set; }
        public string runAreaCode{ get; set; }
        public string runArea{ get; set; }
        public string licenseNo{ get; set; }
        public string engineNo{ get; set; }
        public string enrollDate{ get; set; }
        public string vin{ get; set; }
        public string chgOwnerFlag{ get; set; }
        public string chgOwnerDate{ get; set; }
        public string customerType{ get; set; }
        public string useNature{ get; set; }
        public string countryNature{ get; set; }
        public string licenseType{ get; set; }
        public string carOwner{ get; set; }
        public string ownerIdType{ get; set; }
        public string ownerIdentifyNumber{ get; set; }
        public string ownerPhone{ get; set; }
        public string r_name{ get; set; }
        public string r_type{ get; set; }
        public string r_sex{ get; set; }
        public string r_idType{ get; set; }
        public string r_idNo{ get; set; }
        public string r_age{ get; set; }
        public string r_address{ get; set; }
        public string r_birthday{ get; set; }
        public string r_telePhone{ get; set; }
        public string r_mobilePhone{ get; set; }
        public string r_email{ get; set; }
        public string r_postCode{ get; set; }
        public string r_sendWay{ get; set; }
        public string r_name1{ get; set; }
        public string r_type1{ get; set; }
        public string r_sex1{ get; set; }
        public string r_idType1{ get; set; }
        public string r_idNo1{ get; set; }
        public string r_age1{ get; set; }
        public string r_address1{ get; set; }
        public string r_birthday1{ get; set; }
        public string r_telePhone1{ get; set; }
        public string r_mobilePhone1{ get; set; }
        public string r_email1{ get; set; }
        public string r_postCode1{ get; set; }
        public string r_sendWay1{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
