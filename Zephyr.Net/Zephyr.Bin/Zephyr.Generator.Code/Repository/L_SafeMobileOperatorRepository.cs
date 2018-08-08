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
    public class L_SafeMobileOperatorRepository : BaseRepository<L_SafeMobileOperator>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public L_SafeMobileOperatorRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

