using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ManmonFinancialMapping : EntityTypeConfiguration<T_ManmonFinancial>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_ManmonFinancialMapping()
        {
            ToTable("T_ManmonFinancial");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
