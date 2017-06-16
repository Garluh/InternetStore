using Domain.Abstract;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFDressRepository : IDressRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Dress> Dresses
        {
            get { return context.Dresses; }
        }
    }
}