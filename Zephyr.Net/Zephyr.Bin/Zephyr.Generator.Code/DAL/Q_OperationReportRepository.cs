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
    public class Q_OperationReportRepository : BaseRepository<Q_OperationReport>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_OperationReportRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

