#region

using System;
using System.Collections.Generic;
using System.Reflection;

#endregion

namespace Smartac.SR.Core.IoC
{
    /// <summary>
    /// </summary>
    internal static class Assemblies
    {
        private static readonly Lazy<IEnumerable<Assembly>> assembliesAccessor =
            new Lazy<IEnumerable<Assembly>>(GetAssembliesCore);

        /// <summary>
        /// 获取核心集合
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Assembly> GetAssembliesCore()
        {
            var list = new List<Assembly>();
            AssemblyName[] array =
            {
                new AssemblyName("Smartac.SR.Core"),
                new AssemblyName("Smartac.SR.Core.EntLib")
            };
            AssemblyName[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                AssemblyName assemblyRef = array2[i];
                try
                {
                    Assembly item = Assembly.Load(assemblyRef);
                    list.Add(item);
                }
                catch
                {
                }
            }
            return list;
        }

        public static IEnumerable<Assembly> GetAssemblies()
        {
            return assembliesAccessor.Value;
        }
    }
}