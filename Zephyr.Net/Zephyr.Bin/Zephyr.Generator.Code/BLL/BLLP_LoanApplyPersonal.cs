using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_LoanApplyPersonalBLL : BaseBLL<P_LoanApplyPersonal>
    {
        public P_LoanApplyPersonalDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_LoanApplyPersonalDal();
        }      
    }
}
