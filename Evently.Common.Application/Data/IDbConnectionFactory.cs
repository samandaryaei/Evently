using System.Data.Common;
using System.Threading.Tasks;

namespace Evently.Common.Application.Data;

public interface IDbConnectionFactory
{
    ValueTask<DbConnection> OpenConnectionAsync();
}