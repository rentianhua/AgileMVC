﻿using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.Unity.Utility;
using Smartac.SR.Core.Configuration;
using Smartac.SR.Core.EntLib.SettingSource.Configuration;
using Smartac.SR.Core.IoC;
using Smartac.SR.Core.SettingSource;

namespace Smartac.SR.Core.EntLib.SettingSource
{
    [ConfigurationElement(typeof(ConfigurationFileSettingSourceData)), MapTo(typeof(ISettingSource), 1)]
    public class ConfigurationFileSettingSource : ISettingSource
    {
        private string filePath;
        /// <summary>
        /// Gets the configuration source.
        /// </summary>
        /// <value>
        /// The configuration source.
        /// </value>
        public IConfigurationSource ConfigurationSource
        {
            get;
            private set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Smartac.SR.Core.SettingSource.ConfigurationFileSettingSource" /> class.
        /// </summary>
        public ConfigurationFileSettingSource()
        {
            this.ConfigurationSource = new SystemConfigurationSource();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Smartac.SR.Core.SettingSource.ConfigurationFileSettingSource" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ConfigurationFileSettingSource(string filePath)
        {
            Guard.ArgumentNotNullOrEmpty(filePath, "filePath");
            this.filePath = filePath;
            this.ConfigurationSource = new FileConfigurationSource(filePath);
        }
        /// <summary>
        /// Gets the configuration section based on specified section name.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <returns>
        /// The target configuration section.
        /// </returns>
        public ConfigurationSection GetConfigurationSection(string sectionName)
        {
            Guard.ArgumentNotNullOrEmpty(sectionName, "sectionName");
            return this.ConfigurationSource.GetSection(sectionName);
        }
        /// <summary>
        /// Sets as current settings source.
        /// </summary>
        public void SetAsCurrentSettingsSource()
        {
        }
    }
}
