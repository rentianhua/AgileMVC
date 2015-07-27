#region

using System;
using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Smartac.SR.Core.EntLib.Properties;
using Smartac.SR.Core.IoC;
using Smartac.SR.Core.IoC.Configuration;

#endregion

namespace Smartac.SR.Core.EntLib.IoC.Configuration
{
    /// <summary>
    /// </summary>
    public class UnityContainerServiceLocatorData : ServiceLocatorDataBase
    {
        private const string ContainerNamePropertyName = "containerName";

        /// <summary>
        ///     Gets or sets the name of the container.
        /// </summary>
        /// <value>
        ///     The name of the container.
        /// </value>
        [ConfigurationProperty("containerName", IsRequired = false, DefaultValue = "")]
        public string ContainerName
        {
            get { return (string) base["containerName"]; }
            set { base["containerName"] = value; }
        }

        /// <summary>
        ///     Creates the service locator.
        /// </summary>
        /// <returns>
        ///     The created service locator.
        /// </returns>
        public override IServiceLocator CreateServiceLocator()
        {
            var unityContainer = new UnityContainer();
            UnityConfigurationSection unityConfigurationSection;
            if (ConfigManager.TryGetConfigurationSection("unity", out unityConfigurationSection))
            {
                if (string.IsNullOrWhiteSpace(ContainerName))
                {
                    unityConfigurationSection.Configure(unityContainer);
                }
                else
                {
                    unityConfigurationSection.Configure(unityContainer, ContainerName);
                }
                return new UnityContainerServiceLocator(unityContainer);
            }
            if (!string.IsNullOrWhiteSpace(ContainerName))
            {
                throw new ConfigurationErrorsException(Resources.ExceptionUnityConainerNotExists.Format(new object[]
                {
                    ContainerName
                }));
            }
            return new UnityContainerServiceLocator(unityContainer);
        }
    }
}