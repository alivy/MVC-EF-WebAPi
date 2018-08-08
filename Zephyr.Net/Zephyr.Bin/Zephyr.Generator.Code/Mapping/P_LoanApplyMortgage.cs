using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyMortgageMapping : EntityTypeConfiguration<P_LoanApplyMortgage>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public P_LoanApplyMortgageMapping()
        {
            ToTable("P_LoanApplyMortgage");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
