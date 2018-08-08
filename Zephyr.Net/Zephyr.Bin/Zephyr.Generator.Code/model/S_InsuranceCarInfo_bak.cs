using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_InsuranceCarInfo_bakService : ServiceBase<S_InsuranceCarInfo_bak>
    {
       
    }

    public class S_InsuranceCarInfo_bak : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public string IsNew{ get; set; }
        public string Price{ get; set; }
        public string CarLicenseNo{ get; set; }
        public string VinCode{ get; set; }
        public string EngineNo{ get; set; }
        public string CarProperty{ get; set; }
        public string Property{ get; set; }
        public string RegistDate{ get; set; }
        public string IsTransferCar{ get; set; }
        public string TransferDate{ get; set; }
        public string VehicleName{ get; set; }
        public string VehicleId{ get; set; }
        public string ModelLoads{ get; set; }
        public string Purpose{ get; set; }
        public string Seat{ get; set; }
        public string FullWeight{ get; set; }
        public string DrivingArea{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
