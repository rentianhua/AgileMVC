using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartac.SR.Core.Data
{
    /// <summary>
    /// All database factory classes must implement this interface.
    /// </summary>
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Gets the database.
        /// </summary>
        /// <param name="databaseName">Name of the connection string.</param>
        /// <returns>The <see cref="T:NCS.IConnect.Core.Data.Database" />.</returns>
        Database GetDatabase(string databaseName);
        /// <summary>
        /// Gets the database.
        /// </summary>      
        /// <returns>The <see cref="T:NCS.IConnect.Core.Data.Database" />.</returns>
        Database GetDatabase();
    }
}
