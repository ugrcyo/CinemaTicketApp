using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using ServiceLayer.OPPClass;

namespace ServiceLayer.Manage
{
    public class FilmDaySessionManage : IFilmDaySession
    {
        CinemaDBEntities DB = new CinemaDBEntities();

        public string delete(Film_Day_Session t)
        {
            throw new NotImplementedException();
        }

        public string insert(Film_Day_Session t)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(t.Session_ID.ToString()) && !string.IsNullOrWhiteSpace(t.Film_ID.ToString()) && !string.IsNullOrWhiteSpace(t.Session_Date.ToString()))
                {
                    DB.Film_Day_Session.Add(t);
                    if (DB.SaveChanges() > 0)
                    {
                        return "Insert succesful";
                    }
                    return "Insert failed";
                }
                return "Insert failed";
            }
            catch (Exception msg)
            {

                throw new Exception("Insert failed");
            }
        }

        public List<Film_Day_Session> Lists()
        {
            throw new NotImplementedException();
        }

        public string update(Film_Day_Session t)
        {
            throw new NotImplementedException();
        }
    }
}
