using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_AssetsLoanGroupBLL : BaseBLL<P_AssetsLoanGroup>
    {
        public P_AssetsLoanGroupDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_AssetsLoanGroupDal();
        }      
    }
}
