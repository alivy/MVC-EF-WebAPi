using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MoneyRainPulseMapping : EntityTypeConfiguration<T_MoneyRainPulse>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_MoneyRainPulseMapping()
        {
            ToTable("T_MoneyRainPulse");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
