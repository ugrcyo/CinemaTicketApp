using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using ServiceLayer;

namespace ServiceLayer.OPPClass
{
    interface IFilm:IDbProcess<Film>
    {
    }
}
