using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class C_ChipsSpaceTypeBLL : BaseBLL<C_ChipsSpaceType>
    {
        public C_ChipsSpaceTypeDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new C_ChipsSpaceTypeDal();
        }      
    }
}
