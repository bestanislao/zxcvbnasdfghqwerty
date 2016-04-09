using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Context;

namespace UNBUM.DAO
{
    public class UnitOfWork : IUnitOfWork
    {
        private UNBUMDbContext _context;
        public UnitOfWork(UNBUMDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("UNBUMDbContext");

            _context = context as UNBUMDbContext;
        }
        private bool disposed = false;

        public DbContext Context
        {
            get { return _context; }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
