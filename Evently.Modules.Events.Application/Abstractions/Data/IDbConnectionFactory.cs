using System.Data.Common;
using System.Threading.Tasks;

namespace Evently.Modules.Events.Application.Abstractions.Data;

public interface IDbConnectionFactory
{
    ValueTask<DbConnection> OpenConnectionAsync();
}