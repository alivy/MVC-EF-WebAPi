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
    /// Ͷ����Ŀ�ִ�
    /// </summary>
    public class Q_WPDayProfitRepository : BaseRepository<Q_WPDayProfit>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_WPDayProfitRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

