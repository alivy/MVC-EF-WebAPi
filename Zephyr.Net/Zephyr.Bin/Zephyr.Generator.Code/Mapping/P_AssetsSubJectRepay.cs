using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_AssetsSubJectRepayMapping : EntityTypeConfiguration<P_AssetsSubJectRepay>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public P_AssetsSubJectRepayMapping()
        {
            ToTable("P_AssetsSubJectRepay");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
