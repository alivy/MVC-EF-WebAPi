using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_AnniversaryRedMoneyMapping : EntityTypeConfiguration<T_AnniversaryRedMoney>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public T_AnniversaryRedMoneyMapping()
        {
            ToTable("T_AnniversaryRedMoney");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
