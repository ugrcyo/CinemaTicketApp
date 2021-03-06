﻿using DataBaseLayer;
using ServiceLayer.OPPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Manage
{
    public class FilmManage : IFilm
    {
        CinemaDBEntities db = new CinemaDBEntities();

        public string delete(Film t)
        {
            db.Film.Remove(t);
            if ( db.SaveChanges()>0)
            {
                return "Delete succesful";
            }
            return "Delete failed";
        }

        public string insert(Film t)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(t.Name) && !string.IsNullOrWhiteSpace(t.Film_Genre))
                {
                    db.Film.Add(t);
                    if (db.SaveChanges() > 0)
                    {
                        return "Insert succesful";
                    }
                    return "Insert failed";
                }
                return "Insert failed";
            }
            catch (Exception msg)
            {
               return msg.Message;
            }

        }

        public  List<Film> Lists()
        {
            return db.Film.ToList();
        }

        public List<string> SLists(int film_id)
        {
            var SaloonNameResult = db.SP_GET_SALOONNAME(film_id);
            return SaloonNameResult.ToList();
        }

        public string update(Film t)
        {
           
                try
                {
                    var updatefilm = db.Film.Where(k => k.ID == t.ID).FirstOrDefault();
                    if (updatefilm != null)
                    {
                    if (!string.IsNullOrWhiteSpace(t.Name) && !string.IsNullOrWhiteSpace(t.Film_Genre.ToString()))
                        {
                            updatefilm.Name = t.Name;
                            updatefilm.Film_Genre = t.Film_Genre;
                            updatefilm.Status =true;

                        if (db.SaveChanges() > 0)
                            {
                                return t.ID + " Update successful";
                            }
                            return t.ID + " Update failed";
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
