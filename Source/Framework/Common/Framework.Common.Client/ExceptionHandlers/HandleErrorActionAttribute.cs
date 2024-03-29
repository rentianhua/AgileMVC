﻿#region

using System;

#endregion

namespace Smartac.SR.Framework.Common.Client.ExceptionHandlers
{
    /// <summary>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class HandleErrorActionAttribute : Attribute
    {
        /// <summary>
        /// </summary>
        /// <param name="handleErrorAction"></param>
        public HandleErrorActionAttribute(string handleErrorAction = "")
        {
            HandleErrorAction = handleErrorAction;
        }

        /// <summary>
        /// </summary>
        public string HandleErrorAction { get; private set; }
    }
}