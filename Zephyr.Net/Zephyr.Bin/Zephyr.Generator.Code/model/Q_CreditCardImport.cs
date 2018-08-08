using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditCardImportService : ServiceBase<Q_CreditCardImport>
    {
       
    }

    public class Q_CreditCardImport : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public DateTime? TradeTime{ get; set; }
        public string MerchantID{ get; set; }
        public decimal? TradeAmount{ get; set; }
        public decimal? TradePoundage{ get; set; }
        public int? POSID{ get; set; }
        public int? TradeName{ get; set; }
        public int? TradeState{ get; set; }
        public string BatchNo{ get; set; }
        public string TemplatePath{ get; set; }
    }
}
