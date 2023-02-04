using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CarParts.API.Infrastructure.Data.Repository
{
    public class PartRepository : Repository<Part>,IPartRepository
    {

        public PartRepository(CarPartsContext context ):base(context)
        {
        }
        //private readonly CarPartsContext _context;
        //public PartRepository(CarPartsContext context)
        //{
        //    _context = context;
        //}

        //public async Task<Part> AddAsync(Part entity)
        //{
        //   await _context.AddAsync(entity);

        //   return entity;
        //}

        //public async Task<bool> DeleteAsync(int id)
        //{
        //    var part =await _context.Parts.FindAsync(id);
        //        //FirstOrDefaultAsync(x => x.Id == id);

        //    if(part != null)
        //    {
        //        _context.Remove(part);
        //        return false;
        //    }
        //    else
        //        return true;
            
        //}

        //public  List<Part> GetAllAsync()
        //{
        //   return  _context.Parts.ToList();
        //}

        //public async Task<Part?> GetByIdAsync(int id)
        //{
        //    var part = await _context.Parts.FindAsync(id);
        //        //.FirstOrDefaultAsync(x => x.Id == id);

        //    if(part == null)
        //    {
        //        throw new ArgumentException("Part not found");
        //    }

        //    return part;
        //}

        //public async Task UpdateAsync(int id, Part entity)
        //{
            
        //    _context.Parts.Update(entity);
        //    await _context.SaveChangesAsync();
        //}
    }
}
