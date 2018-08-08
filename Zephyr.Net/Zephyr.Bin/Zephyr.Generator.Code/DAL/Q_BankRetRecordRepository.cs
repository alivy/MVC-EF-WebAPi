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
    public class Q_BankRetRecordRepository : BaseRepository<Q_BankRetRecord>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_BankRetRecordRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

