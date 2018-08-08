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
    public class T_MonthlyActivityRuleRepository : BaseRepository<T_MonthlyActivityRule>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public T_MonthlyActivityRuleRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

