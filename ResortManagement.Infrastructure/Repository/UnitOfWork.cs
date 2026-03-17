using ResortManagement.Application.Common.Interfaces;
using ResortManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagement.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IVillaRepository Villa { get; private set; }

        public IVillaNumberRepository VillaNumber { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {

            _context = context;
            Villa = new VillaRepository(context);
            VillaNumber = new VillaNumberRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}