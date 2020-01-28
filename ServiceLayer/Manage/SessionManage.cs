﻿using System;
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

        public string insert(Session t)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(t.Film_ID.ToString()) && !string.IsNullOrWhiteSpace(t.Session_Beginning.ToString()) && !string.IsNullOrWhiteSpace(t.Film_Duration.ToString()))
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
                if (updatesession != null)
                {
                    if (!string.IsNullOrWhiteSpace(t.Film_Duration.ToString()) && !string.IsNullOrWhiteSpace(t.Session_Beginning.ToString()))
                    {
                        updatesession.Film_Duration = t.Film_Duration;
                        updatesession.Session_Beginning = t.Session_Beginning;
                        updatesession.Session_Finishing = t.Session_Finishing;

                        if (db.SaveChanges() > 0)
                        {
                            return  " Update successful";
                        }
                        return  " Update failed";
                    }
                    return "Validation error";
                }
                return " Update failed";
            }
            catch (Exception msg)
            {

                return msg.Message;
            }
        }
    }
}
