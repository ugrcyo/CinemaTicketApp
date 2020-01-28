using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using ServiceLayer;
using ServiceLayer.Common.DTOS;
using ServiceLayer.OPPClass;

namespace ServiceLayer.Manage
{
    public class SaloonManage : ISaloon
    {
        CinemaDBEntities db = new CinemaDBEntities();

        public string insert(Saloon salon)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(salon.Name) && !string.IsNullOrWhiteSpace(salon.Row_Count.ToString()) && !string.IsNullOrWhiteSpace(salon.Seat_Count.ToString()))
                {
                   
                    db.Saloon.Add(salon);

                    if (db.SaveChanges() > 0)
                    {
                        return salon.Name + " Insert successful";
                    }
                    return salon.Name + " Insert failed";
                }
                return "Validation error";
            }
            catch (Exception msg)
            {

                return msg.Message;
            }
        }

        public string delete(Saloon saloon)
        {

            try
            {
                
                
                db.Saloon.Remove(saloon);
                if (db.SaveChanges() > 0)
                {
                    saloon.ID = 0;
                    return saloon.Name + " Delete successful";
                }
                return saloon.Name + " Delete failed";
            }
            catch (Exception msg)
            {

                return msg.Message;
            }

        }

        public List<Saloon> Lists()
        {
            return db.Saloon.ToList();
        }

        public string update(Saloon saloon)
        {

            try
            {
                var updatesaloon = db.Saloon.Where(k => k.ID == saloon.ID).FirstOrDefault();
                if (updatesaloon != null)
                {
                    if (!string.IsNullOrWhiteSpace(saloon.Name) && !string.IsNullOrWhiteSpace(saloon.Row_Count.ToString()) && !string.IsNullOrWhiteSpace(saloon.Seat_Count.ToString()))
                    {
                        updatesaloon.Name = saloon.Name;
                        updatesaloon.Seat_Count = saloon.Seat_Count;
                        updatesaloon.Row_Count = saloon.Row_Count;

                        if (db.SaveChanges() > 0)
                        {
                            return saloon.ID + " Update successful";
                        }
                        return saloon.ID + " Update failed";
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




