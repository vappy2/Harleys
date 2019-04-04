using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;

namespace DAL
{
    public class HarleyProvider
    {
        public HarleyProvider() { }

        public List<EntityHarley> GetAllHarleys()
        {
            using (GarageContext context = new GarageContext())
            {
                return context.Harleys.ToList();
            }
        }

        //méthode create
        public void Create(EntityHarley Harley)
        {
            using (GarageContext context = new GarageContext())
            {
                try
                {
                    context.Harleys.Add(Harley);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        //méthode update
        public void Update(EntityHarley Harley)
        {
            using (GarageContext context = new GarageContext())
            {
                try
                {
                    context.Harleys.Attach(Harley);
                    //On spécifie l'entité modifiée
                    context.Entry<EntityHarley>(Harley).State = EntityState.Modified;
                }

                catch
                {
                    throw;
                }
            }
        }

        //methode delete

        public void Delete(EntityHarley Harley)
        {
            using (GarageContext context = new GarageContext())
                try
                {
                    context.Harleys.Attach(Harley);
                    context.Harleys.Remove(Harley);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
        }

    }
}
