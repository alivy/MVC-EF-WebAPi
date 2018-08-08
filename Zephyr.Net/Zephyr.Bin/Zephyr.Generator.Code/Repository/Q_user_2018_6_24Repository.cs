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
    public class Q_user_2018_6_24Repository : BaseRepository<Q_user_2018_6_24>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_user_2018_6_24Repository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

