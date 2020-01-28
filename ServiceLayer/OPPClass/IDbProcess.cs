using DataBaseLayer;
using ServiceLayer.Common.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer.OPPClass
{
    interface IDbProcess<TEntity>
    {

       string insert(TEntity t);
        string update (TEntity t);
        string delete(TEntity t);
        List<TEntity> Lists();

    }
}
