using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RewardGiftMapping : EntityTypeConfiguration<Q_RewardGift>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_RewardGiftMapping()
        {
            ToTable("Q_RewardGift");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
