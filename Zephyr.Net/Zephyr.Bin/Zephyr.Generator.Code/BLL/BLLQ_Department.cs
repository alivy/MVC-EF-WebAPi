using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_DepartmentBLL : BaseBLL<Q_Department>
    {
        public Q_DepartmentDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_DepartmentDal();
        }      
    }
}
