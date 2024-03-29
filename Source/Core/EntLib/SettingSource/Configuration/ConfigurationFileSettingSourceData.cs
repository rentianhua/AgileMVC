﻿using System.Configuration;
using Smartac.SR.Core.SettingSource;
using Smartac.SR.Core.SettingSource.Configuration;

namespace Smartac.SR.Core.EntLib.SettingSource.Configuration
{
    public class ConfigurationFileSettingSourceData : SettingSourceDataBase
    {
        private const string FilePathPropertyName = "filePath";
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        [ConfigurationProperty("filePath", IsRequired = false, DefaultValue = "")]
        public string FilePath
        {
            get
            {
                return (string)base["filePath"];
            }
            set
            {
                base["filePath"] = value;
            }
        }
        /// <summary>
        /// Creates the setting source.
        /// </summary>
        /// <returns>
        /// The created setting source.
        /// </returns>
        public override ISettingSource CreateSettingSource()
        {
            if (string.IsNullOrEmpty(this.FilePath))
            {
                return new ConfigurationFileSettingSource();
            }
            return new ConfigurationFileSettingSource(this.FilePath);
        }
    }
}
