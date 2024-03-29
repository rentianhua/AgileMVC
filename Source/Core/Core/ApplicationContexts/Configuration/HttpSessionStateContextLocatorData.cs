﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartac.SR.Core.Configuration;

namespace Smartac.SR.Core.ApplicationContexts.Configuration
{
    /// <summary>
    /// Define the http session state context locator data.
    /// </summary>
    public class HttpSessionStateContextLocatorData : ContextLocatorDataBase
    {
        /// <summary>
        /// Get the delegate to create provider instance.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The delegate to create provider instance.</returns>
        public override Func<IContextLocator> GetProviderCreator(ServiceLocatableSettings settings)
        {
            return () => new HttpSessionStateContextLocator();
        }
    }
}
