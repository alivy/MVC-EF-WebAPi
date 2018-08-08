using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class L_ComInfoAddressBLL : BaseBLL<L_ComInfoAddress>
    {
        public L_ComInfoAddressDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new L_ComInfoAddressDal();
        }      
    }
}
