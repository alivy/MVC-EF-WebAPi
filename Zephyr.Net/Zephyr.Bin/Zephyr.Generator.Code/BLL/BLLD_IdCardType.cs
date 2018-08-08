using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class D_IdCardTypeBLL : BaseBLL<D_IdCardType>
    {
        public D_IdCardTypeDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new D_IdCardTypeDal();
        }      
    }
}
