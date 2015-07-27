using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Utility;
using Smartac.SR.Core.IoC;

namespace Smartac.SR.Core.Data
{
    /// <summary>
    /// The factory to create <see cref="T:NCS.IConnect.Core.Data.Database" /> by the specified connection string name.
    /// </summary>
    public static class DatabaseFactories
    {
        /// <summary>
        /// Gets the database.
        /// </summary>
        /// <param name="databaseName">Name of the connection string.</param>
        /// <returns>The <see cref="T:NCS.IConnect.Core.Data.Database" />.</returns>
        public static Database GetDatabase(string databaseName)
        {
            Guard.ArgumentNotNullOrEmpty(databaseName, "databaseName");
            IServiceLocator serviceLocator = ServiceLocatorFactory.GetServiceLocator(null);
            IDatabaseFactory service = serviceLocator.GetService<IDatabaseFactory>(null);
            return service.GetDatabase(databaseName);
        }
        /// <summary>
        /// Gets the database.
        /// </summary>     
        /// <returns>The <see cref="T:NCS.IConnect.Core.Data.Database" />.</returns>
        public static Database GetDatabase()
        {
            IServiceLocator serviceLocator = ServiceLocatorFactory.GetServiceLocator(null);
            IDatabaseFactory service = serviceLocator.GetService<IDatabaseFactory>(null);
            return service.GetDatabase();
        }
    }
}
