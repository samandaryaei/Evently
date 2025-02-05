﻿using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Evently.Modules.Events.Application.Abstractions.Data;
using Npgsql;

namespace Evently.Modules.Events.Infrastructure.Data;

internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        return await dataSource.OpenConnectionAsync();
    }
}