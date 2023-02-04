using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CarParts.API.Infrastructure.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarPartsContext _context;
        public IPartRepository Parts { get; private set; }
        //private IRepository<Part> _parts;
        public UnitOfWork(CarPartsContext context)
        {
            _context = context;
        }

        public IRepository<Part> Parts
        {
            get
            {
                if (_parts == null)
                {
                    _parts = new PartRepository(_context);
                }

                return _parts;
            }
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
