#region

using System.Collections.Generic;
using System.Reflection;

#endregion

namespace Smartac.SR.Core.IoC
{
    /// <summary>
    /// </summary>
    internal interface IAssemblyResolver
    {
        IEnumerable<Assembly> GetAssemblies();
    }
}