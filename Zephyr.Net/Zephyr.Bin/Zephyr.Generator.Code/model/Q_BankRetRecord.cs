using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BankRetRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public int Q_BankOperateTypeId{ get; set; }
        public string Version{ get; set; }
        public string TxCode{ get; set; }
        public string InstCode{ get; set; }
        public string BankCode{ get; set; }
        public string TxDate{ get; set; }
        public string TxTime{ get; set; }
        public string SeqNo{ get; set; }
        public string Channel{ get; set; }
        public string RetCode{ get; set; }
        public string RetMsg{ get; set; }
        public string AccountId{ get; set; }
        public string AcqRes{ get; set; }
        public string Mobile{ get; set; }
        public string SrvTxCode{ get; set; }
        public string SrvAuthCode{ get; set; }
        public string SendTime{ get; set; }
        public string SmsSeq{ get; set; }
        public string ValidTime{ get; set; }
        public string Currency{ get; set; }
        public decimal? TxAmount{ get; set; }
        public int? ProductId{ get; set; }
        public string ProductDesc{ get; set; }
        public string Name{ get; set; }
        public string NominalAcctountId{ get; set; }
        public int? State{ get; set; }
        public int? RedId{ get; set; }
        public int? LvBondId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string OrderId{ get; set; }
        public string AuthCode{ get; set; }
        public int? BatchNo{ get; set; }
        public decimal? SucAmount{ get; set; }
        public int? SucCounts{ get; set; }
        public decimal? FailAmount{ get; set; }
        public int? FailCounts{ get; set; }
        public string BatchTxCode{ get; set; }
        public string SubPacks{ get; set; }
        public int? AccType{ get; set; }
        public string AcctUse{ get; set; }
        public decimal? AvailBal{ get; set; }
        public decimal? CurrBal{ get; set; }
        public int? WithdrawFlag{ get; set; }
        public string StartDate{ get; set; }
        public string EndDate{ get; set; }
        public int? Type{ get; set; }
        public int? PageNum{ get; set; }
        public int? PageSize{ get; set; }
        public int? TotalItems{ get; set; }
        public string idType{ get; set; }
        public string idNo{ get; set; }
        public string openDate{ get; set; }
        public string acctState{ get; set; }
        public string frzState{ get; set; }
        public string pinLosCd{ get; set; }
        public string reqType{ get; set; }
        public string reqTxCode{ get; set; }
        public string reqTxDate{ get; set; }
        public string reqTxTime{ get; set; }
        public string reqSeqNo{ get; set; }
        public string reqOrderId{ get; set; }
        public string txState{ get; set; }
        public string failMsg{ get; set; }
        public string batchTxDate{ get; set; }
        public decimal? relAmount{ get; set; }
        public int? relCounts{ get; set; }
        public string batchState{ get; set; }
        public decimal? ForIncome{ get; set; }
        public string BuyDate{ get; set; }
        public decimal? BonusAmount{ get; set; }
        public string Caccount{ get; set; }
        public string BusId{ get; set; }
        public string TaxId{ get; set; }
        public string PinFlag{ get; set; }
    }
}
