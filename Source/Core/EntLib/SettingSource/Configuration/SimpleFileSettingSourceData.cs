#region

using System.Configuration;
using Smartac.SR.Core.SettingSource;
using Smartac.SR.Core.SettingSource.Configuration;

#endregion

namespace Smartac.SR.Core.EntLib.SettingSource.Configuration
{
    /// <summary>
    ///     The simple configuration file based setting source.
    /// </summary>
    public class SimpleFileSettingSourceData : SettingSourceDataBase
    {
        private const string ConfigurationFilePathProperty = "filePath";

        /// <summary>
        ///     Gets or sets the file path.
        /// </summary>
        /// <value>
        ///     The file path.
        /// </value>
        [ConfigurationProperty("filePath", IsRequired = false, DefaultValue = "")]
        public string FilePath
        {
            get { return (string) base["filePath"]; }
            set { base["filePath"] = value; }
        }

        /// <summary>
        ///     Creates the setting source.
        /// </summary>
        /// <returns>
        ///     The created setting source.
        /// </returns>
        public override ISettingSource CreateSettingSource()
        {
            return string.IsNullOrEmpty(FilePath) ? new SimpleFileSettingSource() : new SimpleFileSettingSource(FilePath);
        }
    }
}