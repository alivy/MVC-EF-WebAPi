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
    public class Q_ConsultantDept_UserRepository : BaseRepository<Q_ConsultantDept_User>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_ConsultantDept_UserRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

