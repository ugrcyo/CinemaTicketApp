using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using ServiceLayer.OPPClass;

namespace ServiceLayer.Manage
{
    public class SessionManage : ISession
    {
        CinemaDBEntities db = new CinemaDBEntities();
        public string delete(Session t)
        {
            throw new NotImplementedException();
        }

        public List<string> Ses_List(int saloon_id)
        {
            var sessionresult = db.SP_GET_SESSIONTIME(saloon_id);
            return sessionresult.ToList();
        }

        public string insert(Session t)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(t.Session1.ToString()) && !string.IsNullOrWhiteSpace(t.Saloon_ID.ToString()))
                {
                    db.Session.Add(t);
                    if (db.SaveChanges() > 0)
                    {
                        return "Insert succesful";
                    }
                    return "Insert failed";
                }
                return "Empty area";
            }
            catch (Exception msg)
            {

                return msg.Message;
            }
        }

        public List<Session> Lists()
        {
            return db.Session.ToList();
        }

       
        
        public string update(Session t)
        {
            try
            {
                var updatesession = db.Session.Where(k => k.ID == t.ID).FirstOrDefault();

                    if (!string.IsNullOrWhiteSpace(t.Session1.ToString()) && !string.IsNullOrWhiteSpace(t.Saloon_ID.ToString()))
                    {
                        
                        db.Entry(updatesession).CurrentValues.SetValues(t);

                        if (db.SaveChanges() > 0)
                        {
                            return " Update successful";
                        }
                        return " Update failed";
                    }
                    return "Validation error";
            }
            catch (Exception msg)
            {

                return msg.Message;
            }
        }
    }
}
