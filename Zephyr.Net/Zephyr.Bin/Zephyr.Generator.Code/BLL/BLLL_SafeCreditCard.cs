using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class L_SafeCreditCardBLL : BaseBLL<L_SafeCreditCard>
    {
        public L_SafeCreditCardDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new L_SafeCreditCardDal();
        }      
    }
}
