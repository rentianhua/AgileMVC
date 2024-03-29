﻿#region

using Smartac.SR.Framework.Common.Server.BaseClasses;

#endregion

namespace Smartac.SR.Modules.Customer.DataAccess
{
    /// <summary>
    ///     The data access of Data asscss base class.
    /// </summary>
    /// <remarks></remarks>
    public abstract class CustomerDataAccessBase : DataAccessBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.MarshalByRefObject" /> class.
        /// </summary>
        /// <remarks></remarks>
        protected CustomerDataAccessBase()
            : base()
        {
        }
    }
}