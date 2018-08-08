using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SmsSendRecordBLL : BaseBLL<Q_SmsSendRecord>
    {
        public Q_SmsSendRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SmsSendRecordDal();
        }      
    }
}
