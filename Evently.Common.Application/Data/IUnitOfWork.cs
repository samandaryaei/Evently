using System.Threading;
using System.Threading.Tasks;

namespace Evently.Common.Application.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}