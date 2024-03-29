﻿#region

using System;
using System.Configuration;
using System.Linq;
using System.Xml;
using Microsoft.Practices.Unity.Utility;
using Smartac.SR.Core.Properties;

#endregion

namespace Smartac.SR.Core.Configuration
{
    /// <summary>
    /// 以Name和Type值作为键值的配置元素的元素集合
    /// </summary>
    /// <typeparam name="T">NameTypeConfigurationElement</typeparam>
    public class NameTypeConfigurationElementCollection<T> : ConfigurationElementCollection
        where T : NameTypeConfigurationElement
    {
        /// <summary>
        /// 根据泛型NameTypeConfigurationElement的T创建实例
        /// </summary>
        /// <returns>NameTypeConfigurationElement</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// 获取元素NameTypeConfigurationElement键值
        /// </summary>
        /// <param name="element">NameTypeConfigurationElement</param>
        /// <returns>NameTypeConfigurationElement.Name</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((NameTypeConfigurationElement)element).Name;
        }

        /// <summary>
        /// 获取配置元素中的type值
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>NameTypeConfigurationElement.Type</returns>
        protected virtual Type GetConfigurationElementType(XmlReader reader)
        {
            Type result = null;
            if (reader.AttributeCount > 0)
            {
                var flag = reader.MoveToNextAttribute();
                while (flag)
                {
                    if ("type" == reader.Name)
                    {
                        string value = reader.Value;
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            return null;
                        }
                        Type type = Type.GetType(value, false);
                        if (null == type)
                        {
                            throw new ConfigurationErrorsException(
                                Resources.ExceptionCannotResolveTypeName.Format(new object[]
                                {
                                    value
                                }));
                        }
                        var configurationElementAttribute =
                            AttributeAccessor.GetAttributes<ConfigurationElementAttribute>(type, false)
                                .OfType<ConfigurationElementAttribute>()
                                .FirstOrDefault<ConfigurationElementAttribute>();
                        if (configurationElementAttribute == null)
                        {
                            throw new InvalidOperationException(
                                Resources.ExceptionNotApplyConfigurationElementAttribute.Format(new object[]
                                {
                                    type
                                }));
                        }
                        result = configurationElementAttribute.ConfigurationElementType;
                    }
                    flag = reader.MoveToNextAttribute();
                }
                reader.MoveToElement();
            }
            return result;
        }

        /// <summary>
        /// 反序列化无法认识的元素
        /// </summary>
        /// <param name="elementName"></param>
        /// <param name="reader"></param>
        /// <returns>
        ///     true 如果反序列化成功; 否则, false. 默认是false.
        /// </returns>
        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader)
        {
            if (base.AddElementName == elementName)
            {
                Type configurationElementType = GetConfigurationElementType(reader);
                var t = (T)Activator.CreateInstance(configurationElementType);
                t.Deserialize(reader);
                base.BaseAdd(t, true);
                return true;
            }
            return base.OnDeserializeUnrecognizedElement(elementName, reader);
        }

        /// <summary>
        /// 通过name获取NameTypeConfigurationElement
        /// </summary>
        /// <param name="name"></param>
        /// <returns>NameTypeConfigurationElement</returns>
        public T GetConfigurationElement(string name)
        {
            Guard.ArgumentNotNullOrEmpty(name, "name");
            if (!base.BaseGetAllKeys().Contains(name))
            {
                throw new ConfigurationErrorsException(Resources.ConfiguraitonElementNotExists.Format(new object[]
                {
                    name
                }));
            }
            return base.BaseGet(name) as T;
        }
    }
}