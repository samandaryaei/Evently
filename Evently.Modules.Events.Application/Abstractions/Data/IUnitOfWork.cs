using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Events.Application.Abstractions.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}