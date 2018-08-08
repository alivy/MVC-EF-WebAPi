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
    public class Q_BannerRepository : BaseRepository<Q_Banner>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public Q_BannerRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

