using Domain.Abstract;
using System.Collections.Generic;
using Domain.Entities;
using System;

namespace Domain.Concrete
{
    public class EFDressRepository : IDressRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Dress> Dresses
        {
            get { return context.Dresses; }
        }

        public void SaveDress(Dress dress)
        {
            if (dress.DressId == 0)
            {
                context.Dresses.Add(dress);

            }
            else
            {
                Dress dbEntry = context.Dresses.Find(dress.DressId);
                if (dbEntry !=null)
                {
                    dbEntry.Name = dress.Name;
                    dbEntry.Description = dress.Description;
                    dbEntry.Category = dress.Category;
                    dbEntry.SpecOffer = dress.SpecOffer;
                    dbEntry.Price = dress.Price;
                }
            }
            context.SaveChanges();

        }
    }
}