﻿#region

using System;
using System.Configuration;
using System.Linq;
using Smartac.SR.Core.Configuration;
using Smartac.SR.Core.Properties;

#endregion

namespace Smartac.SR.Core.SettingSource.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    [ConfigurationSectionName("sr.settingSource")]
    public class SettingSourceSettings : ConfigurationSection
    {
        private const string DefaultSettingSourcePropertyName = "defaultSettingSource";
        private const string SettingSourcesPropertyName = "settingSources";

        /// <summary>
        ///     Gets the default setting source.
        /// </summary>
        /// <value>
        ///     The default setting source.
        /// </value>
        [ConfigurationProperty("defaultSettingSource", IsRequired = true)]
        public string DefaultSettingSource
        {
            get { return (string)base["defaultSettingSource"]; }
        }

        /// <summary>
        ///     Gets the setting sources.
        /// </summary>
        /// <value>
        ///     The setting sources.
        /// </value>
        [ConfigurationProperty("settingSources", IsRequired = true)]
        public NameTypeConfigurationElementCollection<SettingSourceDataBase> SettingSources
        {
            get { return (NameTypeConfigurationElementCollection<SettingSourceDataBase>)base["settingSources"]; }
        }

        /// <summary>
        ///     Gets the setting source.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="T:System.Configuration.ConfigurationErrorsException"></exception>
        public ISettingSource GetSettingSource(string name = null)
        {
            //获取默认的SettingSource
            if (string.IsNullOrWhiteSpace(name))
            {
                return SettingSources.GetConfigurationElement(DefaultSettingSource).CreateSettingSource();
            }

            //获取指定的SettingSource
            if (SettingSources.Cast<SettingSourceDataBase>()
                .Any((SettingSourceDataBase element) => element.Name == name))
            {
                return SettingSources.GetConfigurationElement(name).CreateSettingSource();
            }
            throw new ConfigurationErrorsException(Resources.ExceptionSettingSourceNotExists.Format(new object[]
            {
                name
            }));
        }
    }
}