using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_LoanApplyBagBLL : BaseBLL<P_LoanApplyBag>
    {
        public P_LoanApplyBagDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_LoanApplyBagDal();
        }      
    }
}
