using System;
using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Users.Domain.Users;

public interface IUserRepository
{
    Task<User> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(User user);
}
