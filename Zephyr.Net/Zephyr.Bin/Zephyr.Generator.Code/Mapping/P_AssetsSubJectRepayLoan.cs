using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsSubJectRepayLoanMapping : EntityTypeConfiguration<P_AssetsSubJectRepayLoan>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public P_AssetsSubJectRepayLoanMapping()
        {
            ToTable("P_AssetsSubJectRepayLoan");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
