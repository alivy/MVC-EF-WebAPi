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
    public class Q_CreditCardImportRepository : BaseRepository<Q_CreditCardImport>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_CreditCardImportRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

