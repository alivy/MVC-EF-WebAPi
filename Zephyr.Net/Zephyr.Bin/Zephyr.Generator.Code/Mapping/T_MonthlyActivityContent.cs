using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivityContentMapping : EntityTypeConfiguration<T_MonthlyActivityContent>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_MonthlyActivityContentMapping()
        {
            ToTable("T_MonthlyActivityContent");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
