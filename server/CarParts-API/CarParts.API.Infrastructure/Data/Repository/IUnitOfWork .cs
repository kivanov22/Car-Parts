using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Infrastructure.Data.Common;

namespace CarParts.API.Infrastructure.Data.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        //IRepository<Part> Parts { get; }
        IPartRepository Parts { get; }
        Task CommitAsync();
    }
}
