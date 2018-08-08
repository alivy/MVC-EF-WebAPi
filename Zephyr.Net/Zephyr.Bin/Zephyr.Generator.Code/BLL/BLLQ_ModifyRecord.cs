using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_ModifyRecordBLL : BaseBLL<Q_ModifyRecord>
    {
        public Q_ModifyRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_ModifyRecordDal();
        }      
    }
}
