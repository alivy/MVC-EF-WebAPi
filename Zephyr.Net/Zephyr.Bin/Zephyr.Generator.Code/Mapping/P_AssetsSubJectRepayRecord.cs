using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsSubJectRepayRecordMapping : EntityTypeConfiguration<P_AssetsSubJectRepayRecord>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public P_AssetsSubJectRepayRecordMapping()
        {
            ToTable("P_AssetsSubJectRepayRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
