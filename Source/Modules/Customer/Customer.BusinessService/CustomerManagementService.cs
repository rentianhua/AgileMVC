#region

using System.Collections.Generic;
using Smartac.SR.AuditTrail.Interception;
using Smartac.SR.Framework.Common.Server.BaseClasses;
using Smartac.SR.Modules.Customer.BusinessComponent;
using Smartac.SR.Modules.Customer.Interface;

#endregion

namespace Smartac.SR.Modules.Customer.BusinessService
{
    /// <summary>
    /// </summary>
    public class CustomerManagementService : ServiceBase<CustomerBC>, ICustomerManagementService
    {
        /// <summary>
        /// </summary>
        public CustomerManagementService(CustomerBC bc)
            : base(bc)
        {
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [AuditTrailCallHandler("GetALlCustomers")]
        public List<dynamic> GetALlCustomers()
        {
            return BusinessComponent.GetALlCustomers();
        }
    }
}