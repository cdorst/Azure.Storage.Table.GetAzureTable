// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static Azure.Storage.Connection.GetConnectionString.ConnectionStringGetter;
using static Azure.Storage.Table.GetOrCreateTableReference.TableReferenceGetterOrCreator;

namespace Azure.Storage.Table.GetAzureTable
{
    /// <summary>Function returns a reference of a new or existing Microsoft Azure CloudTable using the environment's connection string and given table name</summary>
    public static class AzureTableGetter
    {
        /// <summary>Returns a reference of a new or existing Microsoft Azure CloudTable using the environment's connection string and given table name</summary>
        public static async Task<CloudTable> AzureTable(string tableName) => await GetOrCreateAzureTable(ConnectionString(), tableName);
    }
}
