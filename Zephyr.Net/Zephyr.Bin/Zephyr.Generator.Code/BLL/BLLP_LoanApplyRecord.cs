using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_LoanApplyRecordBLL : BaseBLL<P_LoanApplyRecord>
    {
        public P_LoanApplyRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_LoanApplyRecordDal();
        }      
    }
}
