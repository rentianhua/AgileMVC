#region

using System.Collections.Generic;
using Smartac.SR.AuditTrail.Interception;
using Smartac.SR.Framework.Common.Server.BaseClasses;
using Smartac.SR.Modules.Customer.DataAccess;

#endregion

namespace Smartac.SR.Modules.Customer.BusinessComponent
{
    /// <summary>
    /// </summary>
    public class CustomerBC : BusinessComponentBase<CustomerDA>
    {
        /// <summary>
        /// </summary>
        /// <param name="da"></param>
        public CustomerBC(CustomerDA da)
            : base(da)
        {
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        //[AuditTrailCallHandler("GetALlCustomers")]
        public List<dynamic> GetALlCustomers()
        {
            return DataAccess.GetALlCustomers();
        }
    }
}