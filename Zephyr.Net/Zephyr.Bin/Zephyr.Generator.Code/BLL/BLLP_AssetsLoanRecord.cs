using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_AssetsLoanRecordBLL : BaseBLL<P_AssetsLoanRecord>
    {
        public P_AssetsLoanRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_AssetsLoanRecordDal();
        }      
    }
}
