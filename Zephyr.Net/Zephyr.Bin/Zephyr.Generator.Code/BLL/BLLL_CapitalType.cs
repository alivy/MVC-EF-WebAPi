using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class L_CapitalTypeBLL : BaseBLL<L_CapitalType>
    {
        public L_CapitalTypeDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new L_CapitalTypeDal();
        }      
    }
}
