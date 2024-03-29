﻿using System;
using System.Runtime.Serialization;
using Microsoft.Practices.Unity.Utility;
using Smartac.SR.Core.Properties;

namespace Smartac.SR.Core.ApplicationContexts
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = "http://www.smartac.co/")]
    [Serializable]
    public class ContextItem
    {
        private object value;
        /// <summary>
        /// Can be considered the unique name of the context item in the collection.
        /// </summary>
        [DataMember(Name = "Key", IsRequired = true, Order = 1)]
        public string Key
        {
            get;
            private set;
        }

        /// <summary>
        /// The value of the context item.
        /// </summary>
        [DataMember(Name = "Value", IsRequired = true, Order = 2)]
        public object Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (this.ReadOnly)
                {
                    throw new InvalidOperationException(ResourceUtility.Format(Resources.ExceptionCannotModifyReadonlyValue, new object[0]));
                }
                this.value = value;
            }
        }

        /// <summary>
        /// Indicates whether the context item is read-only or writable, and the default value is false.
        /// </summary>
        [DataMember(Name = "ReadOnly", IsRequired = true, EmitDefaultValue = true, Order = 3)]
        public bool ReadOnly
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is local.
        /// </summary>
        /// <value><c>true</c> if this instance is local; otherwise, <c>false</c>.</value>
        public bool IsLocal
        {
            get;
            private set;
        }

        /// <summary>
        ///   The extended property collection bound to the context item.
        /// </summary>
        [DataMember(Name = "ExtendedProperties", IsRequired = false, EmitDefaultValue = false)]
        public ExtendedPropertyCollection ExtendedProperties
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the ContextItem class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="isLocal">if set to <c>true</c> [is local].</param>
        public ContextItem(string key, object value, bool isLocal)
        {
            Guard.ArgumentNotNullOrEmpty(key, "key");
            Guard.ArgumentNotNull(value, "value");
            this.Key = key;
            this.Value = value;
            this.IsLocal = isLocal;
            this.ExtendedProperties = new ExtendedPropertyCollection(this);
        }

        /// <summary>
        /// Initializes a new instance of the ContextItem class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public ContextItem(string key, object value)
            : this(key, value, false)
        {
        }
    }
}
