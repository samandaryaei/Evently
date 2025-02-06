using System;
using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Events.Domain.Categories;

public interface ICategoryRepository
{
    Task<Category> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Category category);
}
