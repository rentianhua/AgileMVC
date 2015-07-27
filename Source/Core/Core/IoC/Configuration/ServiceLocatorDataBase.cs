#region

using Smartac.SR.Core.Configuration;

#endregion

namespace Smartac.SR.Core.IoC.Configuration
{
    /// <summary>
    /// 提供创建ServiceLocator的配置基类
    /// </summary>
    public abstract class ServiceLocatorDataBase : NameTypeConfigurationElement
    {
        /// <summary>
        ///     Creates the service locator.
        /// </summary>
        /// <returns>The created service locator.</returns>
        public abstract IServiceLocator CreateServiceLocator();
    }
}