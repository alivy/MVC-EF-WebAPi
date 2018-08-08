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
    public class Q_SignBorrowerAllRecordRepository : BaseRepository<Q_SignBorrowerAllRecord>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_SignBorrowerAllRecordRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

