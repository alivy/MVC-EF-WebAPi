using QFTService.Domain;
using QFTService.Domain.Repository.Interfaces;
using QFTService.DtoModel;
using QFTService.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Repository
{
    /// <summary>
    /// 投资项目仓储
    /// </summary>
    public class Q_User_20180612Repository : BaseRepository<Q_User_20180612>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_User_20180612Repository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

