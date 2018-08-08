using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class D_AreaBLL : BaseBLL<D_Area>
    {
        public D_AreaDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new D_AreaDal();
        }      
    }
}
