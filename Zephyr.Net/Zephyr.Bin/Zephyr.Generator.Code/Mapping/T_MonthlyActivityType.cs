using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivityTypeMapping : EntityTypeConfiguration<T_MonthlyActivityType>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_MonthlyActivityTypeMapping()
        {
            ToTable("T_MonthlyActivityType");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
