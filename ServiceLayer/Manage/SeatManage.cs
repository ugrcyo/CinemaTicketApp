using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.OPPClass;
using DataBaseLayer;


namespace ServiceLayer.Manage
{
    class SeatManage:ISeat
    {
        CinemaDBEntities DB = new CinemaDBEntities();

        public string delete(Seat t)
        {
            throw new NotImplementedException();
        }

        public string insert(Seat t)
        {
            try
            {
                DB.Seat.Add(t);
                if (DB.SaveChanges() > 0)
                {
                    return "Insert succesful";
                }
                return "Insert failed";
            }
            catch (Exception)
            {

                throw new Exception("Insert failed");
            }
        }

        public List<Seat> Lists()
        {
            throw new NotImplementedException();
        }

        public string update(Seat t)
        {
            throw new NotImplementedException();
        }
    }
}
