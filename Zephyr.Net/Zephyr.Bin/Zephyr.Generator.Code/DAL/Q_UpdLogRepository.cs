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
    public class Q_UpdLogRepository : BaseRepository<Q_UpdLog>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_UpdLogRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

