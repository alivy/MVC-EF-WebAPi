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
    public class Q_BankAccountRepository : BaseRepository<Q_BankAccount>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_BankAccountRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

