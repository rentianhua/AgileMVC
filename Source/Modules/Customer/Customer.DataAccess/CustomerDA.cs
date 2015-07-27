#region

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Smartac.SR.Modules.Customer.DataAccess
{
    /// <summary>
    /// </summary>
    public class CustomerDA : CustomerDataAccessBase
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public List<dynamic> GetALlCustomers()
        {
           return new List<dynamic>();
            //return base.Helper.Query<dynamic>("select * from sr_customer").ToList();
        }
    }
}