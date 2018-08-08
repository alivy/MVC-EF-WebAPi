using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_UserInfo_DeptMapping : EntityTypeConfiguration<Q_R_UserInfo_Dept>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_R_UserInfo_DeptMapping()
        {
            ToTable("Q_R_UserInfo_Dept");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
