using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeCarInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string orderId{ get; set; }
        public string modelCode{ get; set; }
        public string brandName{ get; set; }
        public string factory{ get; set; }
        public string carBrand{ get; set; }
        public string carYear{ get; set; }
        public string familyName{ get; set; }
        public string cIModelClass{ get; set; }
        public string purchasePrice{ get; set; }
        public string purchasePriceNotTax{ get; set; }
        public string analogyModelPrice{ get; set; }
        public string analogyModelPriceNotTax{ get; set; }
        public string riskFlag{ get; set; }
        public string seatCount{ get; set; }
        public string tonCount{ get; set; }
        public string exhaustScale{ get; set; }
        public string fullWeight{ get; set; }
        public string carStyle{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
